using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp096;
using PlayerRoles;
using System;
using System.Collections.Generic;

namespace Scp096Notifications
{
    public class EventHandlers
    {
        
        private Plugin plugin;
        public EventHandlers(Plugin plugin) { this.plugin = plugin; }
        public void Scp096AddingTarget(AddingTargetEventArgs ev)
        {
            if (ev.Target.Role.Team == Team.SCPs || !ev.IsAllowed) return;
            
            if (plugin.Config.Enable096SeenMessage)
            {
                ShowMessage(ev.Target, plugin.Config.Scp096SeenMessage, plugin.Config.NotifDuration);
                Log.Debug("Successfully notified 096 with the player who have looked at its face!");
            }
            if (plugin.Config.Enable096NewTargetMessage)
            {
                string message = plugin.Config.Scp096NewTargetMessage.Replace("{name}", ev.Target.Nickname).Replace("{class}", $"<color={ev.Target.Role.Color.ToHex()}>{plugin.Config.RoleStrings?[ev.Target.Role] ?? "UNKNOWN"}</color>");
                ShowMessage(ev.Target, message, plugin.Config.NotifDuration);
                Log.Debug("Successfully notified the player who have looked at 096's face!");
            }
        }

        public void ShowMessage(Player Ply, string Message, ushort Duration = 3)
        {
            if (plugin.Config.UseHints)
                Ply.ShowHint(Message, Duration);
            else
                Ply.Broadcast(Duration, Message, shouldClearPrevious: true);
        }
    }
}
