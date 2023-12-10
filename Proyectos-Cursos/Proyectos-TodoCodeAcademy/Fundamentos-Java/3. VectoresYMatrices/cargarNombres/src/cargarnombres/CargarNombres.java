/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package cargarnombres;

/**
 *
 * @author PC-1
 */
public class CargarNombres {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        String listaDeNombres[] = new String[8];
        
        listaDeNombres[0] = "Alejandra";
        listaDeNombres[1] = "Ludmila";
        listaDeNombres[2] = "Gabriel";
        listaDeNombres[3] = "Rosa";
        listaDeNombres[4] = "Luisina";
        listaDeNombres[5] = "Daniel";
        listaDeNombres[6] = "Loky";
        listaDeNombres[7] = "Lumel";
        
        for (int posicion = 0; posicion < 8; posicion++) {
            System.out.println("En la posicion " + posicion + " se encuntra el nombre: " + listaDeNombres [posicion]);
        }
    }
    
}
