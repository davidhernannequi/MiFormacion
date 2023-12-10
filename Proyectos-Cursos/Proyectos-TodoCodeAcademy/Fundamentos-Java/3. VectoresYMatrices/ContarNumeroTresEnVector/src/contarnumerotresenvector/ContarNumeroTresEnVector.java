/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package contarnumerotresenvector;

import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class ContarNumeroTresEnVector {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int vectorDeNumeros[] = new int[15];
        int contador = 0;
        Scanner teclado = new Scanner(System.in);
        
        for (int i = 0; i < 15; i++) {
            System.out.print("Ingrese un Numero: ");
            int numero = teclado.nextInt();
            vectorDeNumeros[i] = numero;
            
            if(vectorDeNumeros[i] == 3)
                contador++;
        }
        
        System.out.println("El numero Tres se repite: " + contador + " veces.");
    }
    
}
