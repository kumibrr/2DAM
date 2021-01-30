package com.company;

import com.company.model.Vehiculo;

import java.util.List;


public interface IDAOVehiculo 
{
  public int insertVehiculo(Vehiculo vehiculo);
  public int removeVehiculo(Vehiculo vehiculo);
  public int removeVehiculo(String matricula);
  public int removeVehiculos(List<Vehiculo> lstVehiculos);
  public Vehiculo getVehiculo(String matricula);
  public  List<Vehiculo> getVehiculos();

}
