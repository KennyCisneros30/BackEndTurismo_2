﻿using Data.Contexts;
using Data.Models;

using (var context = new transporteContext()) // Cambia al nombre de tu contexto si es diferente
{
    var transporte = new Transporte
    {
        Type = "aereo",
        Brand = "Vehículo audi",
        Description = " preocuparte de cómo estará la ruta. Es el vehículo ideal para las salidas de campo y las aventuras en todo el Ecuador.",
        Capacity = "10 pasajeros",
        Confort = "para pasar solo",
        Image = "https://gurudeautos.com/wp-content/uploads/2021/05/image-Test-Drive-Pick-Up-Chevrolet-S10-LS-Doble-Cabina-MT-4x2-01-1.jpg",
        Price = 100
    };

    // Agregar transporte a la base de datos
    context.Transportes.Add(transporte);
    context.SaveChanges();

    // Recuperar y mostrar todos los transportes de la base de datos
    var transportes = context.Transportes.ToList();
    foreach (var trans in transportes)
    {
        Console.WriteLine($"Type: {trans.Type}, Brand: {trans.Brand}, Capacity: {trans.Capacity}, Price: {trans.Price}");
    }
}

using (var context = new restauranteContext())
{
    var restaurante = new Restaurante();
    restaurante.Nombre = "El Random";
    restaurante.Tipo = "Multicultural";
    restaurante.Direccion = "Av. 9 de Octubre Moreno, Guayaquil";
    restaurante.Calificacion = 5.0M; // Usamos un valor decimal
    restaurante.Especialidad = "Desayuno, Comidas, Cenas, Brunch, Bebidas";
    restaurante.Foto = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2b/5e/d4/7d/caption.jpg?w=900&h=500&s=1";

    context.Restaurantes.Add(restaurante);
    context.SaveChanges();

    var restaurantes = context.Restaurantes.ToList();

    foreach (var rest in restaurantes)
    {
        Console.WriteLine($"Nombre: {rest.Nombre}, Type: {rest.Tipo}, Dirección: {rest.Direccion}, Calificación: {rest.Calificacion}, Especialidad: {rest.Especialidad}, Foto: {rest.Foto}");
    }
}
