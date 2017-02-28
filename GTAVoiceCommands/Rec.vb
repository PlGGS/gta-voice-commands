Imports GTA
Imports Microsoft.Speech

Public Class Rec
    Inherits Script

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    'Load
    Public Sub New()

        Interval = 1

        reco = Main.reco

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

End Class