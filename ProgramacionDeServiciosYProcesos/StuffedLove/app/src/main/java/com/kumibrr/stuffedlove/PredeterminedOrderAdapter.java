package com.kumibrr.stuffedlove;

import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
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

    class PlushHolder extends RecyclerView.ViewHolder implements View.OnClickListener{

        public PlushHolder(@NonNull View itemView) {
            super(itemView);
            itemView.setOnClickListener(this::onClick);
        }

        private CheckBox chk;

        public void render(StandardPlush plush) {
            chk = itemView.findViewById(R.id.itemCheck);
            ImageView img = itemView.findViewById(R.id.itemImage);
            TextView txt = itemView.findViewById(R.id.itemSize);
            chk.setText(plush.getName());
            img.setImageDrawable(ContextCompat.getDrawable(itemView.getContext(), plush.getImageID()));
            txt.setText(plush.getSize().toString());
            chk.setOnCheckedChangeListener(checkedChangeListener);
        }

        CompoundButton.OnCheckedChangeListener checkedChangeListener = (buttonView, isChecked) -> {
            List l = PredeterminedOrderActivity.selectedPlushies;
            if (!isChecked) {
                l.remove(plushes.get(getLayoutPosition()));
            } else {
                l.add(plushes.get(getLayoutPosition()));
            }
            Log.d("SELECTED PLUSH", l.toString());
        };

        @Override
        public void onClick(View v) {
            chk.toggle();
        }
    }

}
