package com.example.vehiculos;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import com.example.vehiculos.model.Vehiculo;

import java.util.ArrayList;

public class VehiculosAdapter extends RecyclerView.Adapter<VehiculosAdapter.ItemHolder> {

    private ArrayList<Vehiculo> list;
    private DBAccess dbVehiculos;

    public VehiculosAdapter(Context context) {
        dbVehiculos = DBAccess.getInstance(context);
        list = (ArrayList<Vehiculo>) dbVehiculos.getVehiculos();
        Log.e("v", "a");
    }

    @NonNull
    @Override
    public ItemHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        return new ItemHolder(inflater.inflate(R.layout.vehiculo_item, parent, false));
    }

    @Override
    public void onBindViewHolder(@NonNull ItemHolder holder, int position) {
        holder.render(position);
    }

    @Override
    public int getItemCount() {
        return list.size();
    }

    class ItemHolder extends RecyclerView.ViewHolder {

        public ItemHolder(@NonNull View itemView) {
            super(itemView);

            itemView.setOnClickListener(v -> {
                Context context = v.getContext();
                Intent intent = new Intent(context, VehiculoDetail.class);
                intent.putExtra("index", getLayoutPosition());
                Log.e("index", intent.getExtras().toString());
                context.startActivity(intent);
            });
        }

        public void render(int position) {
            Vehiculo vehiculo = list.get(position);

            TextView registration = itemView.findViewById(R.id.registrationText);
            registration.setText(vehiculo.getRegistrationId());
        }

    }
}