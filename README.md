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

## TIPOS


• GetType()
Devuelve	el	tipo	de	un	objeto.

• Typeof()
Podemos	preguntar	por	un	tipo	especifico.

• Is
Pregunta	si	un	tipo	pertenece	al	árbol	de	herencia