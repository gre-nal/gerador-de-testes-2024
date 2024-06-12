﻿using System.Globalization;

namespace gerador_de_testes_2024.Compartilhado;

public static class StringExtensions
{
    public static string ToTitleCase(this string textoEscolhido)
    {
        var textoQuebrado = textoEscolhido.Split(' ');

        for (var i = 0; i < textoQuebrado.Length; i++)
        {
            var palavraMaiuscula = CultureInfo
                .CurrentCulture
                .TextInfo
                .ToTitleCase(textoQuebrado[i].ToLower());

            textoQuebrado[i] = palavraMaiuscula;
        }

        return string.Join(" ", textoQuebrado);
    }
}