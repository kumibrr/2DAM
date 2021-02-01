package com.kumibrr.stuffedlove;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.List;

public class PredeterminedOrderAdapter extends RecyclerView.Adapter<PredeterminedOrderAdapter.PlushHolder> {

    List<StandardPlush> plushes;

    public PredeterminedOrderAdapter(List<StandardPlush> plushes) {
        this.plushes = plushes;
    }

    @NonNull
    @Override
    public PredeterminedOrderAdapter.PlushHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        return new PlushHolder(inflater.inflate(R.layout.item_predeterminedorder, parent, false));
    }

    @Override
    public void onBindViewHolder(@NonNull PredeterminedOrderAdapter.PlushHolder holder, int position) {
        holder.render(plushes.get(position));
    }

    @Override
    public int getItemCount() {
        return plushes.size();
    }

    class PlushHolder extends RecyclerView.ViewHolder {

        public PlushHolder(@NonNull View itemView) {
            super(itemView);
        }

        public void render(StandardPlush plush) {
            CheckBox chk = itemView.findViewById(R.id.itemCheck);
            ImageView img = itemView.findViewById(R.id.itemImage);
            TextView txt = itemView.findViewById(R.id.itemSize);
            chk.setText(plush.getName());
            img.setImageDrawable(plush.getImage());
            txt.setText(plush.getSize().toString());
        }
    }
}
