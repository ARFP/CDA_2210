import React from 'react';
import Image from 'next/image';

export default class PokemonListe extends React.Component
{
    render() {
        return (
            <div>
                <h1>Liste des Pokemons</h1>
                <Image src="/images/pikachu.png" width={320} height={320} alt="Photo de Pikachu"></Image>

                <Image src="/images/pokemon.png" width={320} height={320} alt="Photo de Pikachu"></Image>
            </div>
        );
    }
}

/*
export default function PokemonListe() {
    return (
        <h1>Liste des Pokemons</h1>
    );
}
*/