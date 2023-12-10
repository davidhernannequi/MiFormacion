/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package aerolinea;

import java.util.Scanner;

/**
 *
 * @author PC-1
 */
public class Aerolinea {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        Scanner teclado = new Scanner(System.in);
        Scanner teclado2 = new Scanner(System.in);

        int asientosDisponibles[][] = new int[6][3];

        for (int f = 0; f < 6; f++) {
            for (int c = 0; c < 3; c++) {
                System.out.println("Ingrese la cantidad de asientos disponibles para el destino: " + f + " en el horario: " + c);
                asientosDisponibles[f][c] = teclado.nextInt();
            }
        }

        String cerrar = "";
        int destino, horario, asientos;

        while (!cerrar.equalsIgnoreCase("finish")) {
            System.out.println("Los destinos disponibles son:\n0 - Rio de Janeiro\n1 - Cancún\n2 - Madrid\n3 - Roma\n4 - Milan\n5 - Iguazu");
            System.out.println("Ingrese el numero de destino(entre 0 y 5)");
            destino = teclado.nextInt();
            System.out.println("Los horarios disponibles son:\n0 - Mañana \n1 - Tarde\n2 - Noche");
            System.out.println("Ingrese el numero de horario(entre 0 y 3)");
            horario = teclado.nextInt();
            System.out.println("Ingrese el numero de asientos a reservar");
            asientos = teclado.nextInt();

            //validacion de destino y horario correctos
            if (destino >= 0 && destino < 6) {
                if (horario >= 0 && horario < 3) {
                    if (asientosDisponibles[destino][horario] >= asientos) {
                        asientosDisponibles[destino][horario] -= asientos;
                        System.out.println("Quedan " + asientosDisponibles[destino][horario] + " asientos disponibles");
                        System.out.println("Su reserva fue realizada con exito");
                    } else {
                        System.out.println("Disculpe no se pudo completar su operacion dado que no hay suficientes asientos disponibles.");
                        System.out.println("Quedan " + asientosDisponibles[destino][horario] + " asientos disponibles");
                    }
                } else {
                    System.out.println("Horario invalido, ingrese entre 0 y 2");
                }
            } else {
                    System.out.println("Destino invalido, ingrese entre 0 y 5");
            }

            System.out.print("Desea continuar la reserva? Ingrese ingrese cualquier tecla, sino ingrese finish: ");
            cerrar = teclado2.next();
        }
    }

}
