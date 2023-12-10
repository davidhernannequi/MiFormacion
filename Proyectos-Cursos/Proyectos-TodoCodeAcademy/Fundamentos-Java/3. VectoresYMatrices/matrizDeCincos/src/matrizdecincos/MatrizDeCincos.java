/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package matrizdecincos;

/**
 *
 * @author PC-1
 */
public class MatrizDeCincos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int matrizDeCincos [][] = new int [4][5];
        
        for (int f = 0; f < 4; f++) {
            for (int c = 0; c < 5; c++) {
                matrizDeCincos[f][c] = 5;
                System.out.print(" " + matrizDeCincos[f][c]);
            }
            System.out.println("");
        }
    }
    
}
