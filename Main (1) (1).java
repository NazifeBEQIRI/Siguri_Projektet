package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.geometry.Insets;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.scene.layout.GridPane;
import javafx.scene.control.TextField;
import javafx.scene.control.TextArea;
import javafx.scene.control.Label;
import javafx.scene.control.Button;


import java.awt.*;

public class Main extends Application {

        static int length = 0;
         static String [][] table;

    
    static String[][] cipherTable(String key){

        String[][] playfairTable = new String[5][5];
        String keyString = key + "ABCDEFGHIKLMNOPQRSTUVWXYZ";

        for(int i = 0; i < 5; i++)
            for(int j = 0; j < 5; j++)
                playfairTable[i][j] = "";

        for(int k = 0; k < keyString.length(); k++){
            boolean repeat = false;
            boolean used = false;
            for(int i = 0; i < 5; i++){
                for(int j = 0; j < 5; j++){
                    if(playfairTable[i][j].equals("" + keyString.charAt(k))){
                        repeat = true;
                    }else if(playfairTable[i][j].equals("") && !repeat && !used){
                        playfairTable[i][j] = "" + keyString.charAt(k);
                        used = true;
                    }
                }
            }
        }
        return playfairTable;
    }

    static String cipher(String in){
        length = (int) in.length() / 2 + in.length() % 2;


        for(int i = 0; i < (length - 1); i++){
            if(in.charAt(2 * i) == in.charAt(2 * i + 1)){
                in = new StringBuffer(in).insert(2 * i + 1, 'X').toString();
                length = (int) in.length() / 2 + in.length() % 2;
            }
        }

        String[] digraph = new String[length];
        for(int j = 0; j < length ; j++){
            if(j == (length - 1) && in.length() / 2 == (length - 1))
                in = in + "X";

            digraph[j] = in.charAt(2 * j) +""+ in.charAt(2 * j + 1);
        }

        String out = "";
        String[] encDigraphs = new String[length];
        encDigraphs = encodeDigraph(digraph);
        for(int k = 0; k < length; k++)
            out = out + encDigraphs[k];
        return out;
    }


    static String[] encodeDigraph(String di[]){
        String[] enc = new String[length];
        for(int i = 0; i < length; i++){
            char a = di[i].charAt(0);
            char b = di[i].charAt(1);
            int r1 = (int) getPoint(a).getX();
            int r2 = (int) getPoint(b).getX();
            int c1 = (int) getPoint(a).getY();
            int c2 = (int) getPoint(b).getY();

        
            if(r1 == r2){
                c1 = (c1 + 1) % 5;
                c2 = (c2 + 1) % 5;

              
            }else if(c1 == c2){
                r1 = (r1 + 1) % 5;
                r2 = (r2 + 1) % 5;

               
            }else{
                int temp = c1;
                c1 = c2;
                c2 = temp;
            }

            
            enc[i] = table[r1][c1] + "" + table[r2][c2];

        }
        return enc;
    }

    static String decode(String out){
        String decoded = "";
        for(int i = 0; i < out.length() / 2; i++){
            char a = out.charAt(2*i);
            char b = out.charAt(2*i+1);
            int r1 = (int) getPoint(a).getX();
            int r2 = (int) getPoint(b).getX();
            int c1 = (int) getPoint(a).getY();
            int c2 = (int) getPoint(b).getY();
            if(r1 == r2){
                c1 = (c1 + 4) % 5;
                c2 = (c2 + 4) % 5;
            }else if(c1 == c2){
                r1 = (r1 + 4) % 5;
                r2 = (r2 + 4) % 5;
            }else{
                int temp = c1;
                c1 = c2;
                c2 = temp;
            }
            decoded = decoded + table[r1][c1] + table[r2][c2];
        }
        return decoded;

    }

    static Point getPoint(char c){
        Point pt = new Point(0,0);
        for(int i = 0; i < 5; i++)
            for(int j = 0; j < 5; j++)
                if(c == table[i][j].charAt(0))
                    pt = new Point(i,j);
        return pt;
    }




    Stage window;
    @Override
    public void start(Stage primaryStage) throws Exception{
        window = primaryStage;
        window.setTitle("Playfair-Cipher");

        GridPane grid = new GridPane();
        grid.setPadding(new Insets(10,10,10,10));
        grid.setVgap(8);
        grid.setHgap(10);

      
        Label plainTextLabel = new Label("PlainText");
        GridPane.setConstraints(plainTextLabel,0,0);

        TextField plaintextInput = new TextField();
        GridPane.setConstraints(plaintextInput,1,0);

        Label celesiLabel = new Label("Celesi ");
        GridPane.setConstraints(celesiLabel,0,1);

        TextField celesiInput = new TextField();
        GridPane.setConstraints(celesiInput,1,1);

        Label enc = new Label("Teksti i enkriptuar:");
        GridPane.setConstraints(enc,0,4);

        Label decoded = new Label("Teksti i dekriptuar:");
        GridPane.setConstraints(decoded,0,5);

        Button button = new Button("Run");
        GridPane.setConstraints(button,1,3);


        button.setOnAction(e -> {

            String pt = plaintextInput.getText();



            String encrypted_text = cipher(pt);
            String decrypted_text = decode(encrypted_text);


            enc.setText("Teksti i enkriptuar: " + encrypted_text);
            decoded.setText("Teksti i dekriptuar: " + decrypted_text);

        });

        grid.getChildren().addAll(plainTextLabel,plaintextInput,celesiLabel,celesiInput,button,enc,decoded);

        Scene scene = new Scene(grid,500,500);
        window.setScene(scene);
        window.show();


    }


    public static void main(String[] args) {
        launch(args);
    }
}
