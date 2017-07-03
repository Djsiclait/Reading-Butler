package Student;

import Student.Controllers.LoginController;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.fxml.LoadException;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.MalformedURLException;

/**
 * Created by Djidjelly Siclait on 7/1/2017.
 */
public class Main extends Application {

    // Primary Stage
    private Stage primaryStage;

    // START HERE
    public static void main(String[] args) {
        launch(args);
    }

    public Stage getPrimaryStage(){
        return this.primaryStage;
    }

    @Override
    public void start(Stage primaryStage) throws Exception{
        this.primaryStage = primaryStage;

        // Opening Login View
        loginLayout();
    }

    // Client View Layouts
    public void loginLayout(){
        primaryStage.setTitle("Reading Butler");

        try {
            FXMLLoader loader = new FXMLLoader();
            loader.setLocation(getClass().getResource("resources/UI/login.fxml"));

            primaryStage.setScene(new Scene((AnchorPane) loader.load()));

            LoginController loginController = loader.getController();
            loginController.setMainApp(this);

            primaryStage.setResizable(false);
            primaryStage.setMaximized(false);

            primaryStage.show();

        } catch (MalformedURLException e){
            // TODO: Create Error scenarios
            System.out.println(e.getMessage());
        } catch (LoadException e){
            // TODO: Create Error scenarios
            System.out.println(e.getMessage());
        } catch (IOException e){
            // TODO: Create Error scenarios
            System.out.println(e.getMessage());
        } catch (Exception e){
            // TODO: Create Error scenarios
            System.out.println(e.getMessage());
        }
    }
}