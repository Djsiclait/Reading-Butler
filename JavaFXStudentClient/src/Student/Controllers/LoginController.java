package Student.Controllers;

import Student.Main;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;

import java.util.prefs.Preferences;

/**
 * Created by Djidjelly Siclait on 7/1/2017.
 */
public class LoginController {

    // Main App
    private Main mainApp;

    // FXMLS
    @FXML
    TextField username_textfield;
    @FXML
    PasswordField password_passwordField;
    @FXML
    Button login_button;

    // Configuration ans Setup Functions
    public void setMainApp(Main mainApp){
        this.mainApp = mainApp;
    }

    public void initialize(){
        Preferences.systemNodeForPackage(LoginController.class);
    }


    // Functions
    public void authenticateUser(){
        System.out.println(username_textfield.getText());
        System.out.println(password_passwordField.getText());
    }

    public void summonRegisterPage(){
        System.out.println("register");
    }

    public void initiatePasswordRetrievalProtocol(){
        System.out.println("Resetting password");
    }
}
