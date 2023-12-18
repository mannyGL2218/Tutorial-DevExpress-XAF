;#DropDB CreacionTestEasyTest

#Application CreacionTestWin
;#Application CreacionTestWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef CreacionTestWin

*Action About...
 
*Action OK

#EndIf

#IfDef CreacionTestWeb
*Action Navigation(My Details)
#EndIf
