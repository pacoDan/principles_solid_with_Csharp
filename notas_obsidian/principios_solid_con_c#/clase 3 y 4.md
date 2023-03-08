	como logramos codigo limpio
		- Mantener bajo acoplamiento
			- no debe existir dependencia de un componente con otro
		- utilizar sintaxis simple y actual:
			- codigo simple, sintaxis acordes a las actualizaciones del lenguaje de programacion
		- Evitar incorporar muchas librerias de terceros
			genera mucha dependencia
		- Distribucion de Responsabilidades
			- cada componente haga una responsabilidad especifica
			- si el componente se cambia, puede haber conflictos en los equipos, por eso
		- Creación de componentes pequeños

Solid ayuda a tener codigo limpio y buenas practicas, son la base para esto.

**S.O.L.I.D**  
S = Sigle responsibility principle - Principio de responsabilidad única.  
	una unica responsabilidad  a cada uno de los componentes del sistema
O = Open/closed principle - Principio abierto-cerrado.  
	un codigo debe estar abierto a extensiones y cerrados para cambios
L = Liskov substitution principle - Principio de sustitución de Liskov.  
	relacionde los tipos y sibtipos del sistema
I = Interface segregation principle - Principio de segregación de interfaz.  
	nos ayuda a asignar una responsabilidad unica a cada una de las interfaces  del sistema
D = Dependency inversion principle -Principio de inversión de dependencia.
	concepto de inyeccion de dependencias, para evitar acoplamiento del sistema

Características de SOLID:
• Orientada al paradigma de orientación a
 objetos ( POO )
• Se le atribuye a Robert C. Martin (el autor de Clean Code)
• Diseño y refactorización de código
• Se debe implementar desde el inicio del proyecto cuando se crean los componentes
 
SOLID Ayuda a :
• Lograr código escalable
• Evitar deuda técnica ( Technical debt )
	los cambios que nos toque en hacer en el futuro
• Plantear los fundamentos para el desarrollo guiado por pruebas ( TDD )
	el patron arq  que nos permita construir pruebas unitarias, nos ayuda a validar el codigo que estamos haciendo
• Tener un estándar claro en cada uno de los proyectos de un portafolio

