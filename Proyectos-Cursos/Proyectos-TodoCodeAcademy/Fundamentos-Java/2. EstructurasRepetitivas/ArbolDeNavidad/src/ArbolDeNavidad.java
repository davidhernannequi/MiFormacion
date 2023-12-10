/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
import java.util.Scanner;
/**
 *
 * @author PC-1
 */
public class ArbolDeNavidad {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
       System.out.print("Ingrese la altura del arbol: "); 
       Scanner teclado = new Scanner(System.in);
       int altura = teclado.nextInt();
       
       System.out.print("Ingrese la altura del tronco: ");
       int alturaTronco = teclado.nextInt();
       
       System.out.println("");
       
       //arbol
       for(int fila=0; fila < altura; fila++) {
           
           for(int espacio = 0; espacio <(altura - fila - 1); espacio++) {
               System.out.print(" ");
           }
           
           for (int asterisco = 0; asterisco < ((fila*2)+1); asterisco++) {
               System.out.print("*");
           }
           System.out.println("");
       }
       
       //tronco
       for (int largo = 0; largo < alturaTronco; largo++) {
            
           for (int espacio = 0; espacio < (altura-2); espacio++) {
           System.out.print(" ");
           }
        
           for (int tronco = 0; tronco < 3; tronco++) {
           System.out.print("|");
           }
        
           System.out.println("");
       }
        
       for (int piso = 0; piso < ((altura*2)-1); piso++) {
            System.out.print("-");
       }
        
       System.out.println("");
    }
}
