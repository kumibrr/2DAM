/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package javaapplication1;

import java.util.List;

/**
 *
 * @author israeldelabarrera
 */
public interface IDAOVehiculo {
  public int insertVehiculo(Vehiculo vehiculo);
  public int deleteVehiculo(Vehiculo vehiculo);
  public int deleteVehiculo(String matricula);
  public int deleteVehiculos(List<Vehiculo> lstVehiculos);
  public Vehiculo getVehiculo(String matricula);
  public  List<Vehiculo> getVehiculos();
}
