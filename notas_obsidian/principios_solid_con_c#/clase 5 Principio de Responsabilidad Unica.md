Principio de responsabilidad única
• Single responsibility principle
• Distribuye las responsabilidades diferentes componentes dentro de un sistema , donde cada componente tiene una única responsabilidad
• Aplica para módulos , clases , métodos y funciones

esto se aplica a clases, a microservicios


Ejemplo
Como usuario luego de confirmar la compra espero ver un mensaje
de confirmación , tener la posibilidad de descargar la factura y un correo electrónico de confirmación .
![[Pasted image 20230307194741.png]]
en este ejemplo se puede hacer 3 componentes desde el punto de vista de responsabilidad

para la proxima clase:

Demo - Escenario
Tenemos una clase StudentRepository
encargada de administrar los datos para el
modelo student , pero en este momento no
cumple con el principio de
responsabilidad única , debe solucionarse .
![[Pasted image 20230307195020.png]]

