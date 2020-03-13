/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package functioninterpolation;


import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.scene.chart.LineChart;
import javafx.scene.chart.NumberAxis;
import javafx.scene.chart.XYChart;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.TextField;
import javafx.scene.layout.AnchorPane;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Label;




/**
 * FXML Controller class
 *
 * @author Serge
 */
public class FXMLController implements Initializable {
    //Окно
    @FXML 
    private AnchorPane pane;
    
    //Переменые
    @FXML
    private TextField textFieldAlpha;
    @FXML
    private TextField textFieldBeta;
    @FXML
    private TextField textFieldGamma;
    @FXML
    private TextField textFieldDelta;
    @FXML
    private TextField textFieldFi;
    
    
    //Размеры плоскости
    @FXML
    private TextField textFieldA;
    @FXML
    private TextField textFieldB;
    @FXML
    private TextField textFieldC;
    @FXML
    private TextField textFieldD;
    @FXML
    private TextField textFieldN;

    @FXML
    private ChoiceBox choiceBoxTau;
    
     @FXML
    private NumberAxis xAxis;
    @FXML
    private NumberAxis yAxis;
    
    @FXML // Плоскость и оси 
    private LineChart<Number, Number> numberLineChart;
    @FXML
    private Label labelError;        
    
    double alpha;
    double beta;
    double gamma;
    double delta;
    double fi ;
        
    double a;
    double b;
    double c;
    double d;
        
    double n;
    
    double tau;
  
    
    @FXML
    private void handleButtonAction()  {
        clearOutput();
        
        if(this.isTrueParametrs()){
            updateParametrs();
            this.labelError.setText("");
        }
        else{
            updateTextFields();
           this.labelError.setText("Неверные параметры"); 
        } 
    }
    
    
    
    protected void handleMouseClick (double posX, double posY) {
        
        
        
        ObservableList<XYChart.Data> datas = FXCollections.observableArrayList();
        ObservableList<XYChart.Data> datas2 = FXCollections.observableArrayList();
        
        double stepX = this.numberLineChart.getWidth() / (b - a);
        double stepY = this.numberLineChart.getHeight() / (d - c);
        
        double x = posX/stepX + a;
        double y = -posY/stepY - c;
        
        for (int i = 0; i < n/2; i++){
            
            double tmpX = x;
            double tmpY = y;
            
            
            datas.add(new XYChart.Data(x, y));
            
            x = tmpX + tau * (derivativeX(tmpX,tmpY));
            y = tmpY + tau * (derivativeY(tmpX,tmpY));
        }
        
        x = posX/stepX + a;
        y = -posY/stepY - c;
        
        for (int i = 0; i < n/2; i++){
            
            double tmpX = x;
            double tmpY = y;
            
            
            datas2.add(new XYChart.Data(x, y));
            
            x = tmpX - tau * (derivativeX(tmpX,tmpY));
            y = tmpY - tau * (derivativeY(tmpX,tmpY));
        }
        
        datas.addAll(datas2);
        addFunctionToChart(datas);
        
        
    }
  
    private double derivativeX(double x, double y) {
        return beta * (alpha*x + gamma)*(delta*y+fi);     
    }
    
    private double derivativeY(double x, double y){
        return delta * x * x + fi * y * y;  
    }
    
    
    
   
   
    //-------------------------ВСЯЧИНА------------------------------
    //Рисует графики на плоскости 
    private void addFunctionToChart( ObservableList<XYChart.Data> datas) {
        XYChart.Series series = new XYChart.Series();
        
        series.setData(datas);
        numberLineChart.getData().add(series);
        System.out.println("Готов");
    }
    
      //Функция для очистки плоскости
    private void clearOutput() {
        numberLineChart.getData().clear(); 
    } 
    
    
    private void updateParametrs() {
        
        this.alpha = Double.parseDouble(this.textFieldAlpha.getText());
        this.beta = Double.parseDouble(this.textFieldBeta.getText());
        this.gamma = Double.parseDouble(this.textFieldGamma.getText());
        this.delta = Double.parseDouble(this.textFieldDelta.getText());
        this.fi = Double.parseDouble(this.textFieldFi.getText());

        this.a = Double.parseDouble(this.textFieldA.getText());
        this.b = Double.parseDouble(this.textFieldB.getText());
        this.c = Double.parseDouble(this.textFieldC.getText());
        this.d = Double.parseDouble(this.textFieldD.getText());

        this.n = Double.parseDouble(this.textFieldN.getText());
        
        this.xAxis.setLowerBound(this.a);
        this.xAxis.setUpperBound(this.b);
        this.yAxis.setLowerBound(this.c);
        this.yAxis.setUpperBound(this.d);
        
        this.tau = (double)this.choiceBoxTau.getValue();
    }
    
    private void updateTextFields() {
        this.textFieldAlpha.setText(String.valueOf(alpha));
        this.textFieldBeta.setText(String.valueOf(beta));
        this.textFieldGamma.setText(String.valueOf(gamma));
        this.textFieldDelta.setText(String.valueOf(delta));
        this.textFieldFi.setText(String.valueOf(fi));
        
        this.textFieldA.setText(String.valueOf(a));
        this.textFieldB.setText(String.valueOf(b));
        this.textFieldC.setText(String.valueOf(c));
        this.textFieldD.setText(String.valueOf(d));
        
        this.textFieldN.setText(String.valueOf(n));
        
    }
    
    private boolean isTrueParametrs() {
        
        
        
        try {
            double alpha = Double.parseDouble(this.textFieldAlpha.getText());
            double beta = Double.parseDouble(this.textFieldBeta.getText());
            double gamma = Double.parseDouble(this.textFieldGamma.getText());
            double delta = Double.parseDouble(this.textFieldDelta.getText());
            double fi = Double.parseDouble(this.textFieldFi.getText());

            double a = Double.parseDouble(this.textFieldA.getText());
            double b = Double.parseDouble(this.textFieldB.getText());
            double c = Double.parseDouble(this.textFieldC.getText());
            double d = Double.parseDouble(this.textFieldD.getText());

            double n = Double.parseDouble(this.textFieldN.getText());

            if(alpha > 100 || beta > 100 || gamma > 100 || delta > 100 || fi > 100) return false;
            if(alpha < -100 || beta < -100 || gamma < -100 || delta < -100 || fi < -100) return false;
            if(a > 100 || b > 100 || c > 100 || d > 100)  return false ;
            if(a < -100 || b < -100 || c < -100 || d < -100) return false;
            if(n < 1 || n > 10000) return false;

            return true;

        } catch (NumberFormatException e) {
            return false;
        }
    }
       
       
    
    
    @Override
    public void initialize(URL url, ResourceBundle rb) {
       this.numberLineChart.getYAxis().setAutoRanging(false);
       this.numberLineChart.getXAxis().setAutoRanging(false);
       this.numberLineChart.setAxisSortingPolicy(LineChart.SortingPolicy.Y_AXIS);
       this.choiceBoxTau.getItems().add(1.0);
       this.choiceBoxTau.getItems().add(0.1);
       this.choiceBoxTau.getItems().add(0.01);
       this.choiceBoxTau.getItems().add(0.001);
       //this.choiceBoxTau.getItems().add(0.0001);
       this.choiceBoxTau.setValue(0.01);
       updateParametrs();
       numberLineChart.setOnMousePressed(event ->{
            handleMouseClick(event.getX(), event.getY());
        });
       
       
       
    
       
       
    }
}
