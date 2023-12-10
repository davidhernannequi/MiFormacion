/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class Maraton {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        System.out.println("Bievenido. Por favor ingrese los datos del concursante");
        Scanner teclado = new Scanner(System.in);
        
        System.out.println("Ingrese DNI: ");
        String dni = teclado.nextLine();
                
        System.out.println("Ingrese NOMBRE: ");
        String nombre = teclado.nextLine();

        Scanner teclado2 = new Scanner(System.in);

        System.out.println("Ingrese EDAD: ");
        int edad = teclado2.nextInt();
        
        while(!(dni.equals("0") || nombre.equalsIgnoreCase("fin"))) {
            
            if(edad >= 50) {
                //adultos mayores
                System.out.println("Adultos mayores");
            } else if (edad > 30) {
                //adultos
                System.out.println("Adultos");
            } else if (edad >= 18) {
                //juveniles
                System.out.println("juveniles");
            } else if (edad >= 11) {
                //Menores B
                System.out.println("Menores B");
            } else if (edad >= 6) {
                //menores A
                System.out.println("Menores A");
            } else {
                System.out.println("Dato invalido, solo pueden participar a partir de los 6 años");
            }
            System.out.println("Ingrese DNI: ");
            dni = teclado.nextLine();
                
            System.out.println("Ingrese NOMBRE: ");
            nombre = teclado.nextLine();

            System.out.println("Ingrese EDAD: ");
            edad = teclado2.nextInt();
        }
    }
    
}
