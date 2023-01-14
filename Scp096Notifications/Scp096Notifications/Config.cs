using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace Scp096Notifications
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Determines whether or not people who view SCP-096's face will be notified.")]
        public bool Enable096SeenMessage { get; set; } = true;
        [Description("Determines whether or not SCP-096 will be notified everytime somebody views his face.")]
        public bool Enable096NewTargetMessage { get; set; } = true;
        [Description("The message to show users who become a target of SCP-096.")]
        public string Scp096SeenMessage { get; set; } = "You are a target of SCP-096!";
        [Description("The message to show SCP-096 when he gains a new target.")]
        public string Scp096NewTargetMessage { get; set; } = "<b>{name}</b> has viewed your face! They are a <b>{class}</b>.";
        [Description("The amount of time to show each individual notification.")]
        public ushort NotifDuration { get; set; } = 5;

        [Description("Determines whether or not to use hints for notifications. Hints may cause conflicts with other plugins. If set to false, broadcasts will be used instead.")]
        public bool UseHints { get; set; } = true;

        [Description("Change the display strings of each class (applies to SCP-096'S notification).")]
        public Dictionary<RoleTypeId, string> RoleStrings { get; set; } = new Dictionary<RoleTypeId, string>
        {
            [RoleTypeId.ClassD] = "Class-D Personnel",
            [RoleTypeId.Scientist] = "Scientist",
            [RoleTypeId.FacilityGuard] = "Facility Guard",
            [RoleTypeId.NtfCaptain] = "NTF Captain",
            [RoleTypeId.NtfSergeant] = "NTF Sergeant",
            [RoleTypeId.NtfSpecialist] = "NTF Specialist",
            [RoleTypeId.NtfPrivate] = "NTF Private",
            [RoleTypeId.ChaosMarauder] = "Chaos Marauder",
            [RoleTypeId.ChaosConscript] = "Chaos Conscript",
            [RoleTypeId.ChaosRepressor] = "Chaos Repressor",
            [RoleTypeId.ChaosRifleman] = "Chaos Rifleman",
            [RoleTypeId.Tutorial] = "Tutorial",
        };

        public bool Debug { get; set; } = false;
    }
}
