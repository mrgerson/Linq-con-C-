﻿LinqQueries queries = new LinqQueries();

//muestra toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());


//libros despues del 2000
//ImprimirValores(queries.LibrosDespuesdel2000());


///Libros que tienen mas de 250 pags y tienen en el titulo la palabra in action
ImprimirValores(queries.LibrosConMasde250PagConPalabrasInAction());

//toda la coleccion
void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   
    foreach(var item in listadelibros)
    {
        //Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());

        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate);

    }
}