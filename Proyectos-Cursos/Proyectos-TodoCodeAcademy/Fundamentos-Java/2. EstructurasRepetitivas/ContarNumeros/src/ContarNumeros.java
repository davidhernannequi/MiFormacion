/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class ContarNumeros {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.print("Ingrese el numero hasta el que quiere contar: ");
        
        Scanner teclado = new Scanner(System.in);
        int numeroLimite = teclado.nextInt();
        int contador = 1;
        
        System.out.println();
        
        while(contador <= numeroLimite){
            System.out.println(contador);
            contador++;
        }
    }
    
}
