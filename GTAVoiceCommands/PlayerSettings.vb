Imports GTA
Imports Microsoft.Speech
Imports System.Windows.Forms
Imports GTAVoiceCommands.Main

Public Class PlayerSettings
    Inherits Script

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Dim boolAddMoney As Boolean = False
    Dim boolSmallLoan As Boolean = False

    Dim byteWantedSetting As SByte = -1
    Dim byteIgnoredSetting As SByte = -1
    Dim byteWeaponSetting As SByte = -1

    Dim boolIsIgnoredByPolice As Boolean = False
    Dim boolIsIgnoredByEveryone As Boolean = False

    Dim boolNeverWanted As Boolean = False
    Dim boolSpeakSubNeverWanted As Boolean = False

    Dim boolInvincible As Boolean = False

    'Load
    Public Sub New()

        Interval = 1

        reco = Main.reco

        Game.Player.IsInvincible = False
        boolInvincible = False

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If boolBVCEnabled = True Then

            Select Case e.Result.Text

                Case strKeyWord & ", add money"

                    boolAddMoney = True

                Case strKeyWord & ", give me a small loan"

                    boolSmallLoan = True

                Case strKeyWord & ", wanted level up"

                    byteWantedSetting = 0

                Case strKeyWord & ", wanted level down"

                    byteWantedSetting = 1

                Case strKeyWord & ", wanted level max"

                    byteWantedSetting = 2

                Case strKeyWord & ", wanted level null"

                    byteWantedSetting = 3

                Case strKeyWord & ", toggle never wanted"

                    If boolNeverWanted = False Then

                        boolNeverWanted = True

                        boolSpeakSubNeverWanted = True

                    Else

                        boolSpeakSubNeverWanted = True

                        boolNeverWanted = False

                    End If

                Case strKeyWord & ", toggle invincibility"

                    boolInvincible = True

                Case strKeyWord & ", toggle ignored by police"

                    byteIgnoredSetting = 0

                Case strKeyWord & ", toggle ignored by everyone"

                    byteIgnoredSetting = 1

                Case strKeyWord & ", add weapon all"

                    byteWeaponSetting = 0

                Case strKeyWord & ", add weapon advanced rifle"

                    byteWeaponSetting = 1

                Case strKeyWord & ", add weapon assault rifle"

                    byteWeaponSetting = 2

                Case strKeyWord & ", add weapon assault shotgun"

                    byteWeaponSetting = 3

                Case strKeyWord & ", add weapon assault smg"

                    byteWeaponSetting = 4

                Case strKeyWord & ", add weapon bat"

                    byteWeaponSetting = 5

                Case strKeyWord & ", add weapon carbon rifle"

                    byteWeaponSetting = 6

                Case strKeyWord & ", add weapon combat pistol"

                    byteWeaponSetting = 7

                Case strKeyWord & ", add weapon crowbar"

                    byteWeaponSetting = 8

                Case strKeyWord & ", add weapon dagger"

                    byteWeaponSetting = 9

                Case strKeyWord & ", add weapon fire extinquisher"

                    byteWeaponSetting = 10

                Case strKeyWord & ", add weapon firework launcher"

                    byteWeaponSetting = 11

                Case strKeyWord & ", add weapon golf club"

                    byteWeaponSetting = 12

                Case strKeyWord & ", add weapon grenade"

                    byteWeaponSetting = 13

                Case strKeyWord & ", add weapon grenade launcher"

                    byteWeaponSetting = 14

                Case strKeyWord & ", add weapon hammer"

                    byteWeaponSetting = 15

                Case strKeyWord & ", add weapon hatchet"

                    byteWeaponSetting = 16

                Case strKeyWord & ", add weapon heavy pistol"

                    byteWeaponSetting = 17

                Case strKeyWord & ", add weapon heavy shotgun"

                    byteWeaponSetting = 18

                Case strKeyWord & ", add weapon heavy sniper"

                    byteWeaponSetting = 19

                Case strKeyWord & ", add weapon homing launcher"

                    byteWeaponSetting = 20

                Case strKeyWord & ", add weapon knife"

                    byteWeaponSetting = 21

                Case strKeyWord & ", add weapon marksman pistol"

                    byteWeaponSetting = 22

                Case strKeyWord & ", add weapon marksman rifle"

                    byteWeaponSetting = 23

                Case strKeyWord & ", add weapon micro smg"

                    byteWeaponSetting = 24

                Case strKeyWord & ", add weapon mini gun"

                    byteWeaponSetting = 25

                Case strKeyWord & ", add weapon molotov"

                    byteWeaponSetting = 26

                Case strKeyWord & ", add weapon musket"

                    byteWeaponSetting = 27

                Case strKeyWord & ", add weapon night stick"

                    byteWeaponSetting = 28

                Case strKeyWord & ", add weapon pistol"

                    byteWeaponSetting = 29

                Case strKeyWord & ", add weapon fifty cal"

                    byteWeaponSetting = 30

                Case strKeyWord & ", add weapon proximity mine"

                    byteWeaponSetting = 31

                Case strKeyWord & ", add weapon pump shotgun"

                    byteWeaponSetting = 32

                Case strKeyWord & ", add weapon rail gun"

                    byteWeaponSetting = 33

                Case strKeyWord & ", add weapon rpg"

                    byteWeaponSetting = 34

                Case strKeyWord & ", add weapon sawn off shotgun"

                    byteWeaponSetting = 35

                Case strKeyWord & ", add weapon smg"

                    byteWeaponSetting = 36

                Case strKeyWord & ", add weapon smoke grenade"

                    byteWeaponSetting = 37

                Case strKeyWord & ", add weapon sniper rifle"

                    byteWeaponSetting = 38

                Case strKeyWord & ", add weapon snowball"

                    byteWeaponSetting = 39

                Case strKeyWord & ", add weapon sns pistol"

                    byteWeaponSetting = 40

                Case strKeyWord & ", add weapon special carbine"

                    byteWeaponSetting = 41

                Case strKeyWord & ", add weapon sticky bomb"

                    byteWeaponSetting = 42

                Case strKeyWord & ", add weapon stun gun"

                    byteWeaponSetting = 43

                Case strKeyWord & ", add weapon vintage pistol"

                    byteWeaponSetting = 44

            End Select

        End If

    End Sub

    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        Try

            If Game.Player.Character.IsAlive Then

                Select Case byteWantedSetting

                    Case 0

                        Game.Player.WantedLevel += 1

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Wanted level: up")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Wanted level: up")

                        End If

                        byteWantedSetting = -1

                    Case 1

                        Game.Player.WantedLevel -= 1

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Wanted level: down")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Wanted level: down")

                        End If

                        byteWantedSetting = -1

                    Case 2

                        Game.Player.WantedLevel = 5

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Wanted level: max")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Wanted level: max")

                        End If

                        byteWantedSetting = -1

                    Case 3

                        Game.Player.WantedLevel = 0

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Wanted level: null")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Wanted level: null")

                        End If

                        byteWantedSetting = -1

                End Select

                If boolNeverWanted = True Then

                    If Game.Player.WantedLevel > 0 Then

                        Game.Player.WantedLevel = 0

                    End If

                End If

                If boolSpeakSubNeverWanted = True And boolNeverWanted = True Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Never wanted: true")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Never wanted: true")

                    End If

                    boolSpeakSubNeverWanted = False

                ElseIf boolSpeakSubNeverWanted = True And boolNeverWanted = False

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Never wanted: false")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Never wanted: false")

                    End If

                    boolSpeakSubNeverWanted = False

                End If

                If boolAddMoney = True Then

                    Game.Player.Money += 1000000

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Money added")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Money added")

                    End If

                    boolAddMoney = False

                End If

                If boolSmallLoan = True Then

                    If boolSettingChangedSpeak = True Then

                        My.Computer.Audio.Play(Application.StartupPath & "\scripts\bvc\sl.wav", AudioPlayMode.Background)

                    End If

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("It has not been easy for me and you know I- I started off in Brooklyn.", 3500)

                        Wait(3500)

                        UI.ShowSubtitle("My father gave me a small loan of a million dollars.")

                    End If

                    Game.Player.Money += 1000000

                    boolSmallLoan = False

                End If

                If boolInvincible = True And Game.Player.Character.IsInvincible = True Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Player invincibility: false")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Player invincibility: false")

                    End If

                    boolInvincible = False

                    Game.Player.Character.IsInvincible = False

                End If

                If boolInvincible = True And Game.Player.Character.IsInvincible = False Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Player invincibility: true")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Player invincibility: true")

                    End If

                    boolInvincible = False

                    Game.Player.Character.IsInvincible = True

                End If

                Select Case byteIgnoredSetting

                    Case 0

                        If boolIsIgnoredByPolice = False Then

                            Game.Player.IgnoredByPolice = True

                            boolIsIgnoredByPolice = True

                            If boolSettingChangedSubtitle = True Then

                                UI.ShowSubtitle("Ignored by police: true")

                            End If

                            If boolSettingChangedSpeak = True Then

                                synth.SpeakAsync("Ignored by police: true")

                            End If

                        Else

                            Game.Player.IgnoredByPolice = False

                            boolIsIgnoredByPolice = False

                            If boolSettingChangedSubtitle = True Then

                                UI.ShowSubtitle("Ignored by police: false")

                            End If

                            If boolSettingChangedSpeak = True Then

                                synth.SpeakAsync("Ignored by police: false")

                            End If

                        End If

                        byteIgnoredSetting = -1

                    Case 1

                        If boolIsIgnoredByEveryone = False Then

                            Game.Player.IgnoredByEveryone = True

                            boolIsIgnoredByEveryone = True

                            If boolSettingChangedSubtitle = True Then

                                UI.ShowSubtitle("Ignored by everyone: true")

                            End If

                            If boolSettingChangedSpeak = True Then

                                synth.SpeakAsync("Ignored by everyone: true")

                            End If

                        Else

                            Game.Player.IgnoredByEveryone = False

                            boolIsIgnoredByEveryone = False

                            If boolSettingChangedSubtitle = True Then

                                UI.ShowSubtitle("Ignored by everyone: false")

                            End If

                            If boolSettingChangedSpeak = True Then

                                synth.SpeakAsync("Ignored by everyone: false")

                            End If

                        End If

                        byteIgnoredSetting = -1

                End Select

                Select Case byteWeaponSetting

                    Case 0

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: all weapons")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: all weapons")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AdvancedRifle, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultRifle, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultShotgun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultSMG, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Bat, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.CarbineRifle, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.CombatPistol, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Crowbar, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Dagger, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.FireExtinguisher, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Firework, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.GolfClub, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Grenade, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.GrenadeLauncher, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Hammer, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Hatchet, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavyPistol, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavyShotgun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavySniper, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HomingLauncher, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Knife, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MarksmanPistol, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MarksmanRifle, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MicroSMG, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Minigun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Molotov, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Musket, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Nightstick, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Pistol, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Pistol50, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.ProximityMine, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.PumpShotgun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Railgun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.RPG, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SawnOffShotgun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SMG, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SmokeGrenade, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SniperRifle, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Snowball, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SNSPistol, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SpecialCarbine, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.StickyBomb, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.StunGun, 999, False, True)
                        Game.Player.Character.Weapons.Give(Native.WeaponHash.VintagePistol, 999, False, True)

                    Case 1

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: advanced rifle")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: advanced rifle")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AdvancedRifle, 999, False, True)

                    Case 2

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: assault rifle")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: assault rifle")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultRifle, 999, False, True)

                    Case 3

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: assualt shotgun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: assault shotgun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultShotgun, 999, False, True)

                    Case 4

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: assault smg")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: assault smg")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.AssaultSMG, 999, False, True)

                    Case 5

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: bat")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: bat")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Bat, 999, False, True)

                    Case 6

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: carbon rifle")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: carbon rifle")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.CarbineRifle, 999, False, True)

                    Case 7

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: combat pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: combat pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.CombatPistol, 999, False, True)

                    Case 8

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: crowbar")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: crowbar")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Crowbar, 999, False, True)

                    Case 9

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: dagger")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: dagger")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Dagger, 999, False, True)

                    Case 10

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: fire extinguisher")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: fire extinguisher")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.FireExtinguisher, 999, False, True)

                    Case 11

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: firework launcher")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: firework launcher")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Firework, 999, False, True)

                    Case 12

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: golf club")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: golf club")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.GolfClub, 999, False, True)

                    Case 13

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: grenade")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: grenade")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Grenade, 999, False, True)

                    Case 14

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: grenade launcher")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: grenade launcher")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.GrenadeLauncher, 999, False, True)

                    Case 15

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: hammer")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: hammer")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Hammer, 999, False, True)

                    Case 16

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: hatchet")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: hatchet")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Hatchet, 999, False, True)

                    Case 17

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: heavy pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: heavy pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavyPistol, 999, False, True)

                    Case 18

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: heavy shotgun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: heavy shotgun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavyShotgun, 999, False, True)

                    Case 19

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: heavy sniper")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: heavy sniper")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HeavySniper, 999, False, True)

                    Case 20

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: homing launcher")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: homing launcher")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.HomingLauncher, 999, False, True)

                    Case 21

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: knife")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: knife")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Knife, 999, False, True)

                    Case 22

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: marksman pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: marksman pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MarksmanPistol, 999, False, True)

                    Case 23

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: marksman rifle")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: marksman rifle")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MarksmanRifle, 999, False, True)

                    Case 24

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: micro SMG")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: micro SMG")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.MicroSMG, 999, False, True)

                    Case 25

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: minigun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: minigun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Minigun, 999, False, True)

                    Case 26

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: molotov")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: molotov")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Molotov, 999, False, True)

                    Case 27

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: musket")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: musket")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Musket, 999, False, True)

                    Case 28

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: night stick")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: night stick")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Nightstick, 999, False, True)

                    Case 29

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Pistol, 999, False, True)

                    Case 30

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: fifty caliber pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: fifty caliber pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Pistol50, 999, False, True)

                    Case 31

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: proximity mine")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: proximity mine")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.ProximityMine, 999, False, True)

                    Case 32

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: pump shotgun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: pump shotgun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.PumpShotgun, 999, False, True)

                    Case 33

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: railgun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: railgun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Railgun, 999, False, True)

                    Case 34

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: RPG")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: RPG")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.RPG, 999, False, True)

                    Case 35

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: sawn off shotgun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: sawn off shotgun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SawnOffShotgun, 999, False, True)

                    Case 36

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: SMG")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: SMG")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SMG, 999, False, True)

                    Case 37

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: smoke grenade")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: smoke grenade")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SmokeGrenade, 999, False, True)

                    Case 38

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: sniper rifle")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: sniper rifle")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SniperRifle, 999, False, True)

                    Case 39

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: snowball")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: snowball")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.Snowball, 999, False, True)

                    Case 40

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: SNS pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: SNS pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SNSPistol, 999, False, True)

                    Case 41

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: special carbine")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: special carbine")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.SpecialCarbine, 999, False, True)

                    Case 42

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: sticky bomb")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: sticky bomb")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.StickyBomb, 999, False, True)

                    Case 43

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: stun gun")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: stun gun")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.StunGun, 999, False, True)

                    Case 44

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Added: vintage pistol")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Added: vintage pistol")

                        End If

                        Game.Player.Character.Weapons.Give(Native.WeaponHash.VintagePistol, 999, False, True)

                End Select

            End If

        Catch ex As NullReferenceException

        End Try

        byteWeaponSetting = -1

    End Sub

End Class