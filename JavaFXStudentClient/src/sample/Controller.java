package sample;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;

public class Controller {
    @FXML
    Button hi;

    @FXML
    TextField hello;

    public void cancel(){
        hello.setText("Yolo");
    }
}
