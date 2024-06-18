VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   1605
   ClientLeft      =   120
   ClientTop       =   465
   ClientWidth     =   3270
   LinkTopic       =   "Form1"
   ScaleHeight     =   1605
   ScaleWidth      =   3270
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Sum"
      Height          =   615
      Left            =   360
      TabIndex        =   0
      Top             =   480
      Width           =   2295
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()

Dim inherit As InheritCOM.ISample
Set inherit = New InheritCOM.Sample

Dim settins As ParentCOM.IBaseSetting
Set settins = New ParentCOM.BaseSetting

Dim sum As Integer
sum = inherit.sum(settins)
MsgBox sum

End Sub
