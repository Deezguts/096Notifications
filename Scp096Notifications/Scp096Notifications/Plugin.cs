using Exiled.API.Enums;
using Exiled.API.Features;
using System;

using Events = Exiled.Events.Handlers;

namespace Scp096Notifications
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Scp096Notifications";

        public override string Author { get; } = "Thunder edited by Deeznuts";

        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(6, 0, 0);

        public override PluginPriority Priority => PluginPriority.Low;

        public static Plugin Singleton;
        private static EventHandlers Handler;

        public override void OnEnabled()
        {
            Singleton = this;
            Handler = new EventHandlers(this);

            // Events
            Events.Scp096.AddingTarget += Handler.Scp096AddingTarget;
            Log.Debug("Scp096.AddingTarget event connected.");

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            // Events
            Events.Scp096.AddingTarget -= Handler.Scp096AddingTarget;
            Log.Debug("Scp096.AddingTarget event disconnected.");

            Singleton = null;
            Handler = null;
            base.OnDisabled();
        }
    }
}
