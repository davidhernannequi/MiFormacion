/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class NotasYPromedios {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        double tabla[][] = new double [4][4];
        int contador = 0;
        double acumulador = 0.00;
        
        for (int f = 0; f < 4; f++) {
            System.out.println("Las Notas del estudiante N° " + (f+1) + " son: ");
            for (int c = 0; c < 3; c++) {
                System.out.println("Ingrese la nota: ");
                tabla[f][c] = teclado.nextDouble();
                acumulador+= tabla[f][c];
                contador++;
            }
            tabla[f][3] = acumulador/contador;
            System.out.println("El Promedio de Notas es: " + tabla[f][3]);
            acumulador = 0.00;
        }
    }
}
