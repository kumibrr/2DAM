namespace AccesoConectado
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.lsTfnos = new System.Windows.Forms.ListBox();
            this.btMostrarDatos = new System.Windows.Forms.Button();
            this.ctSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lsTfnos
            // 
            this.lsTfnos.FormattingEnabled = true;
            this.lsTfnos.Location = new System.Drawing.Point(13, 13);
            this.lsTfnos.Name = "lsTfnos";
            this.lsTfnos.Size = new System.Drawing.Size(257, 108);
            this.lsTfnos.TabIndex = 0;
            // 
            // btMostrarDatos
            // 
            this.btMostrarDatos.Location = new System.Drawing.Point(186, 136);
            this.btMostrarDatos.Name = "btMostrarDatos";
            this.btMostrarDatos.Size = new System.Drawing.Size(84, 23);
            this.btMostrarDatos.TabIndex = 1;
            this.btMostrarDatos.Text = "Mostrar datos";
            this.btMostrarDatos.UseVisualStyleBackColor = true;
            this.btMostrarDatos.Click += new System.EventHandler(this.BtMostrarDatos_Click);
            // 
            // ctSql
            // 
            this.ctSql.Location = new System.Drawing.Point(13, 135);
            this.ctSql.Name = "ctSql";
            this.ctSql.Size = new System.Drawing.Size(157, 20);
            this.ctSql.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 171);
            this.Controls.Add(this.ctSql);
            this.Controls.Add(this.btMostrarDatos);
            this.Controls.Add(this.lsTfnos);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "INYECCION SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lsTfnos;
    private System.Windows.Forms.Button btMostrarDatos;
    private System.Windows.Forms.TextBox ctSql;
  }
}

