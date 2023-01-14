## Scp096 Notifications
Display notifications when a user views SCP-096's face (and display a message to SCP-096 when they gain a new target).

## Configs
| Name                         | Type   | Default                                                                | Description                                                                                                                                 |
|------------------------------|--------|------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------|
| is_enabled                   | bool   | true                                                                   | Enables the plugin.                                                                                                                         |
| enable096_seen_message       | bool   | true                                                                   | Determines whether or not players will be notified upon viewing SCP-096's face.                                                             |
| enable096_new_target_message | bool   | true                                                                   | Determines whether or not SCP-096 will be notified upon receiving a new target.                                                             |
| notif_duration               | number | 5                                                                      | The amount of time to show each individual notification.                                                       |
| use_hints                    | bool   | true                                                                   | Determines whether or not to use hints for notifications. Hints may cause conflicts with other plugins. If set to false, broadcasts will be used instead.          |
| scp096_seen_message          | string | You are a target of SCP-096!                                           | Message to display to targets upon viewing SCP-096's faces.                                                                                 |
| scp096_new_target_message    | string | \<b\>{name}\</b\> has viewed your face! They are a \<b\>{class}\</b\>. | Message to display to SCP-096 upon receiving a new target. {name} changes to the player's name and {class} changes to their class (colored) |
| role_strings                 | Dict   | Defaults to all of the human classes and their display equivalent.     | Provides the ability to change the role strings that show in the {role} field of the SCP-096 new target message.                            |
