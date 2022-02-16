;#DropDB LYSEasyTest

#Application LYSWin
#Application LYSWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef LYSWin

*Action About...
 
*Action OK

#EndIf

#IfDef LYSWeb
*Action Navigation(My Details)
#EndIf
