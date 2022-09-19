# POO

## Repo
```
echo "# POO" >> README.md
git init
git add README.md
git commit -m "first commit" 
git remote add origin https://github.com/damiandar/POO.git
git push -u origin master
```

## Pasos para crear una solución con dos proyectos y crear referencias.
```
mkdir Clase6Solucion

cd Clase6Solucion


dotnet new sln

dotnet new console -o Programa

dotnet new classlib -o Biblioteca

dotnet sln Clase6Solucion.sln add Programa

dotnet sln Clase6Solucion.sln add Biblioteca


dotnet add Programa reference Biblioteca
```
## Nuevas versiones

### Tipo deducido
 
var le dice al compilardor que lo deduzca.

### Propiedades auto implementadas

public int prop {get;set;} 

## TIPOS


• GetType()
Devuelve	el	tipo	de	un	objeto.

• Typeof()
Podemos	preguntar	por	un	tipo	especifico.

• Is
Pregunta	si	un	tipo	pertenece	al	árbol	de	herencia

## Alcance	de	miembros
• Publicas:	No	hay	restricciones	de	uso	de	las	
entidades	así	declaradas.
• Protected:	Accesibles	solo	en	las	clases	derivadas.
• Internal:	Con	este	modificador,	las	entidades	son	
accedidas	solo	por	el	programa	que	contiene	la	
declaración	de	la	entidad.
• Protected	internal:	Es	la	unión	de	los	dos	casos
• Privadas:	Solo	accedidas	en	su	contexto	de	
declaración

