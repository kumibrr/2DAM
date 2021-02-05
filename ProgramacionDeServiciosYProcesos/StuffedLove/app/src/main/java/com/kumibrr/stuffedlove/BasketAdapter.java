package com.kumibrr.stuffedlove;

import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.google.android.material.chip.Chip;
import com.kumibrr.stuffedlove.model.Plush;
import com.kumibrr.stuffedlove.model.StandardPlush;

import java.util.List;

public class BasketAdapter extends RecyclerView.Adapter<BasketAdapter.ItemHolder> {

    private final List<Plush> items;
    private final List<Integer> quantities;

    public BasketAdapter(List<Plush> items, List<Integer> quantity) {
        this.items = items;
        this.quantities = quantity;
    }

    @NonNull
    @Override
    public ItemHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        return new ItemHolder(inflater.inflate(R.layout.item_basket, parent, false));
    }

    @Override
    public void onBindViewHolder(@NonNull ItemHolder holder, int position) {
        holder.render(position);
    }

    @Override
    public int getItemCount() { return items.size(); }

    class ItemHolder extends RecyclerView.ViewHolder {

        TextView textQuantity;

        public ItemHolder(@NonNull View itemView) {
            super(itemView);
        }

        public void render(int position) {
            Plush plush = items.get(position);

            ImageView img = itemView.findViewById(R.id.basketImage);
            TextView name = itemView.findViewById(R.id.basketItemName);
            Chip addQuantity = itemView.findViewById(R.id.basketAddQuantity);
            Chip lessQuantity = itemView.findViewById(R.id.basketMinusQuantity);
            Chip removeItem = itemView.findViewById(R.id.basketRemoveItem);
            textQuantity = itemView.findViewById(R.id.basketQuantity);

            img.setImageDrawable(ContextCompat.getDrawable(itemView.getContext(), plush.getImageID()));
            textQuantity.setText(quantities.get(position).toString());
            if (plush instanceof StandardPlush) {
                name.setText(((StandardPlush) plush).getName());
            } else {
                name.setText("Peluche personalizado");
            }

            addQuantity.setOnClickListener(v -> {
                quantities.set(position, quantities.get(position) + 1);
                textQuantity.setText(quantities.get(position).toString());
            });

            lessQuantity.setOnClickListener(v -> {
                if (quantities.get(position) > 1) {
                    quantities.set(position, quantities.get(position) -1);
                    textQuantity.setText(quantities.get(position).toString());
                }
            });

            removeItem.setOnClickListener(v -> {
                items.remove(position);
                quantities.remove(position);
                notifyItemRemoved(position);
            });
        }

    }
}
