;#DropDB PaymentGatewayEasyTest

#Application PaymentGateway.Win
#Application PaymentGateway.Web
#IfDef PaymentGateway.Win

*Action About...
 
*Action OK

#EndIf

#IfDef PaymentGateway.Web
!Action Navigation(My Details)
#EndIf
