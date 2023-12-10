/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class IngresarPalabras {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Ingrese una palabra");
        System.out.println("Mientras esa palabra sea distinta de salir o s se mostrara por pantalla.");
        Scanner teclado = new Scanner(System.in);
        String palabra = teclado.next();
        
        while(!palabra.equalsIgnoreCase("salir")) {
            System.out.println("La palabra es: " + palabra);
            
            System.out.println("Ingrese una palabra");
            palabra = teclado.next();
        }
    }
    
}
