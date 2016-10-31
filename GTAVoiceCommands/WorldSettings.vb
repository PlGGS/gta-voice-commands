Imports GTA
Imports System.Speech
Imports GTAVoiceCommands.Main

Public Class WorldSettings
    Inherits Script

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Dim intWeatherNum As SByte = -1
    Dim intTimeNum As SByte = -1
    Dim boolToggleTimePaused As Boolean = False
    Dim boolToggleTimeSyncedWithPC As Boolean = False
    Dim boolIsTimePaused As Boolean = False
    Dim boolIsTimeSyncedWithPC As Boolean = False

    'Load
    Public Sub New()

        Interval = 1

        reco = Main.reco

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        If boolBVCEnabled = True Then

            Select Case e.Result.Text

                Case strKeyWord & ", set weather extra sunny"

                    intWeatherNum = 0

                Case strKeyWord & ", set weather clear"

                    intWeatherNum = 1

                Case strKeyWord & ", set weather cloudy"

                    intWeatherNum = 2

                Case strKeyWord & ", set weather smog"

                    intWeatherNum = 3

                Case strKeyWord & ", set weather foggy"

                    intWeatherNum = 4

                Case strKeyWord & ", set weather overcast"

                    intWeatherNum = 5

                Case strKeyWord & ", set weather rain"

                    intWeatherNum = 6

                Case strKeyWord & ", set weather thunderstorm"

                    intWeatherNum = 7

                Case strKeyWord & ", set weather clearing"

                    intWeatherNum = 8

                Case strKeyWord & ", set weather neutral"

                    intWeatherNum = 9

                Case strKeyWord & ", set weather snow"

                    intWeatherNum = 10

                Case strKeyWord & ", set weather blizzard"

                    intWeatherNum = 11

                Case strKeyWord & ", set weather snowlight"

                    intWeatherNum = 12

                Case strKeyWord & ", set weather christmas"

                    intWeatherNum = 13

                Case strKeyWord & ", add time one hour"

                    intTimeNum = 0

                Case strKeyWord & ", subtract time one hour"

                    intTimeNum = 1

                Case strKeyWord & ", set time morning"

                    intTimeNum = 2

                Case strKeyWord & ", set time mid day"

                    intTimeNum = 3

                Case strKeyWord & ", set time evening"

                    intTimeNum = 4

                Case strKeyWord & ", set time midnight"

                    intTimeNum = 5

                Case strKeyWord & ", toggle time pause"

                    boolToggleTimePaused = True

                Case strKeyWord & ", time system sync"

                    boolToggleTimeSyncedWithPC = True

            End Select

        End If

    End Sub

    Public Sub Update(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Tick

        Try

            If Game.Player.Character.IsAlive Then

                Select Case intWeatherNum

                    Case 0

                        World.Weather = Weather.ExtraSunny

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Extra Sunny")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Extra Sunny")

                        End If

                        intWeatherNum = -1

                    Case 1

                        World.Weather = Weather.Clear

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Clear")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Clear")

                        End If

                        intWeatherNum = -1

                    Case 2

                        World.Weather = Weather.Clouds

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Cloudy")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Cloudy")

                        End If

                        intWeatherNum = -1

                    Case 3

                        World.Weather = Weather.Smog

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Smog")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Smog")

                        End If

                        intWeatherNum = -1

                    Case 4

                        World.Weather = Weather.Foggy

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Foggy")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Foggy")

                        End If

                        intWeatherNum = -1

                    Case 5

                        World.Weather = Weather.Overcast

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Overcast")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Overcast")

                        End If

                        intWeatherNum = -1

                    Case 6

                        World.Weather = Weather.Raining

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Rain")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Rain")

                        End If

                        intWeatherNum = -1

                    Case 7

                        World.Weather = Weather.ThunderStorm

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Thunderstorm")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Thunderstorm")

                        End If

                        intWeatherNum = -1

                    Case 8

                        World.Weather = Weather.Clearing

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Clearing")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Clearing")

                        End If

                        intWeatherNum = -1

                    Case 9

                        World.Weather = Weather.Neutral

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Neutral")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Neutral")

                        End If

                        intWeatherNum = -1

                    Case 10

                        World.Weather = Weather.Snowing

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Snow")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Snow")

                        End If

                        intWeatherNum = -1

                    Case 11

                        World.Weather = Weather.Blizzard

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Blizzard")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Blizzard")

                        End If

                        intWeatherNum = -1

                    Case 12

                        World.Weather = Weather.Snowlight

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Snowlight")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Snowlight")

                        End If

                        intWeatherNum = -1

                    Case 13

                        World.Weather = Weather.Christmas

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Weather: Christmas")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Weather: Christmas")

                        End If

                        intWeatherNum = -1

                End Select

                Select Case intTimeNum

                    Case 0

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: one hour added")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: one hour added")

                        End If

                        World.CurrentDate += TimeSpan.FromHours(1)

                    Case 1

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: one hour subtracted")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: one hour subtracted")

                        End If

                        World.CurrentDate -= TimeSpan.FromHours(1)

                    Case 2 'Morning

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: Morning")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: Morning")

                        End If

                        World.CurrentDayTime = TimeSpan.FromHours(8)

                    Case 3 'Mid day

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: Mid day")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: Mid day")

                        End If

                        World.CurrentDayTime = TimeSpan.FromHours(12)

                    Case 4 'Evening

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: Evening")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: Evening")

                        End If

                        World.CurrentDayTime = TimeSpan.FromHours(20)

                    Case 5 'Midnight

                        If boolSettingChangedSubtitle = True Then

                            UI.ShowSubtitle("Time: Midnight")

                        End If

                        If boolSettingChangedSpeak = True Then

                            synth.SpeakAsync("Time: Midnight")

                        End If

                        World.CurrentDayTime = TimeSpan.FromHours(0)

                End Select

                intTimeNum = -1

                If boolToggleTimePaused = True And boolIsTimePaused = True Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Time unpaused")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Time unpaused")

                    End If

                    boolIsTimePaused = False
                    boolToggleTimePaused = False

                End If

                If boolToggleTimePaused = True And boolIsTimePaused = False Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Time paused")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Time paused")

                    End If

                    boolIsTimePaused = True
                    boolToggleTimePaused = False

                End If

                If boolIsTimePaused = True Then

                    World.CurrentDayTime -= TimeSpan.FromMilliseconds(0)

                End If

                If boolToggleTimeSyncedWithPC = True And boolIsTimeSyncedWithPC = True Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Time unsynced From PC")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Time unsynced from PC")

                    End If

                    boolIsTimeSyncedWithPC = False
                    boolToggleTimeSyncedWithPC = False

                End If

                If boolToggleTimeSyncedWithPC = True And boolIsTimeSyncedWithPC = False Then

                    If boolSettingChangedSubtitle = True Then

                        UI.ShowSubtitle("Time synced with PC")

                    End If

                    If boolSettingChangedSpeak = True Then

                        synth.SpeakAsync("Time synced with PC")

                    End If

                    boolIsTimeSyncedWithPC = True
                    boolToggleTimeSyncedWithPC = False

                End If

                If boolIsTimeSyncedWithPC = True Then

                    World.CurrentDate = DateTime.Now

                End If

            End If

        Catch ex As NullReferenceException

        End Try

    End Sub

End Class