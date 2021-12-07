// See https://aka.ms/new-console-template for more information
using ConditionalCompilation;
using System;

Console.WriteLine("Hello, World!");

var venue = new Venue();

// In this project I don't want to have access to Location, and thus not bring in the associated Nuget package. i'm good with this error.
venue.Location = null;