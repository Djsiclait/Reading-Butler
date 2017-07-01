package Student;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

/**
 * Created by Djidjelly Siclait on 7/1/2017.
 */
public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
//        Stage primaryStage = null;
        Parent root = FXMLLoader.load(getClass().getResource("resources/UI/login.fxml"));
        primaryStage.setTitle("Hello World");
        primaryStage.setScene(new Scene(root));
        primaryStage.setResizable(false);
        primaryStage.setMaximized(false);
        primaryStage.show();
    }


    public static void main(String[] args) {
        launch(args);
    }
}