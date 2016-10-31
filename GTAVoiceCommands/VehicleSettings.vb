Imports GTA
Imports System.Speech
Imports GTAVoiceCommands.Main

Public Class VehicleSettings
    Inherits Script

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Dim boolRepairVehicle As Boolean = False

    Dim boolToggleVehicleInvincibility As Boolean = False

    Dim boolToggleVehicleStrongWheels As Boolean = False

    'Load
    Public Sub New()

        Interval = 1

        reco = Main.reco

        boolToggleVehicleInvincibility = False
        boolToggleVehicleStrongWheels = False

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If boolBVCEnabled = True Then

            Select Case e.Result.Text

                Case strKeyWord & ", repair vehicle"

                    boolRepairVehicle = True

                Case strKeyWord & ", toggle vehicle invincibility"

                    boolToggleVehicleInvincibility = True

                Case strKeyWord & ", toggle vehicle strong wheels"

                    boolToggleVehicleStrongWheels = True

            End Select

        End If

    End Sub

    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        Try

            If Game.Player.Character.IsAlive Then

                If Game.Player.Character.IsInVehicle = True Then

                    Dim veh As Vehicle = GTA.Game.Player.Character.CurrentVehicle

                    If boolRepairVehicle = True Then

                        veh.Repair()

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Vehicle repaired")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Vehicle repaired")

                        End If

                        boolRepairVehicle = False

                    End If

                    If boolToggleVehicleInvincibility = True And GTA.Game.Player.Character.CurrentVehicle.IsInvincible = True Then

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Current vehicle invincibility: false")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Current vehicle invincibility: false")

                        End If

                        veh.IsInvincible = False

                        boolToggleVehicleInvincibility = False

                    End If

                    If boolToggleVehicleInvincibility = True And GTA.Game.Player.Character.CurrentVehicle.IsInvincible = False Then

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Current vehicle invincibility: true")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Current vehicle invincibility: true")

                        End If

                        veh.IsInvincible = True

                        boolToggleVehicleInvincibility = False

                    End If

                    If boolToggleVehicleStrongWheels = True And GTA.Game.Player.Character.CurrentVehicle.CanTiresBurst = False Then

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Current vehicle [HasStrongWheels]: false")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Current vehicle [HasStrongWheels]: false")

                        End If

                        veh.CanTiresBurst = True

                        boolToggleVehicleStrongWheels = False

                    End If

                    If boolToggleVehicleStrongWheels = True And GTA.Game.Player.Character.CurrentVehicle.CanTiresBurst = True Then

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Current vehicle [HasStrongWheels]: true")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Current vehicle [HasStrongWheels]: true")

                        End If

                        veh.CanTiresBurst = False

                        boolToggleVehicleStrongWheels = False

                    End If

                End If

            End If

        Catch ex As NullReferenceException

        End Try

    End Sub

End Class