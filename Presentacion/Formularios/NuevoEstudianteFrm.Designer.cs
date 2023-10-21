namespace Presentacion.Formularios
{
    partial class NuevoEstudianteFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDatosEstudiante = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.txt_obsDet = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbNacionalidadEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbCaracterizacion = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbLocalidadEstudiante = new System.Windows.Forms.ComboBox();
            this.txtDireccionEstudiante = new System.Windows.Forms.TextBox();
            this.txtEntreCallesEstudiante = new System.Windows.Forms.TextBox();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.txtApellidosEstudiante = new System.Windows.Forms.TextBox();
            this.txtNombresEstudiante = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.gbDatosResponsable = new System.Windows.Forms.GroupBox();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btn_altaCancel = new System.Windows.Forms.Button();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.cmbNacionalidadResponsable = new System.Windows.Forms.ComboBox();
            this.cmbLocalidadResponsable = new System.Windows.Forms.ComboBox();
            this.txtDireccionResponsable = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidosResponsable = new System.Windows.Forms.TextBox();
            this.txtNombresResponsable = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatosEstudiante.SuspendLayout();
            this.gbObservaciones.SuspendLayout();
            this.gbDatosResponsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosEstudiante
            // 
            this.gbDatosEstudiante.Controls.Add(this.dtpFechaIngreso);
            this.gbDatosEstudiante.Controls.Add(this.dtpFechaNacimiento);
            this.gbDatosEstudiante.Controls.Add(this.gbObservaciones);
            this.gbDatosEstudiante.Controls.Add(this.cmbNacionalidadEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.cmbTurno);
            this.gbDatosEstudiante.Controls.Add(this.cmbCaracterizacion);
            this.gbDatosEstudiante.Controls.Add(this.cmbCategoria);
            this.gbDatosEstudiante.Controls.Add(this.cmbLocalidadEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.txtDireccionEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.txtEntreCallesEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.txtCuil);
            this.gbDatosEstudiante.Controls.Add(this.txtApellidosEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.txtNombresEstudiante);
            this.gbDatosEstudiante.Controls.Add(this.cmbGenero);
            this.gbDatosEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatosEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEstudiante.ForeColor = System.Drawing.Color.White;
            this.gbDatosEstudiante.Location = new System.Drawing.Point(10, 10);
            this.gbDatosEstudiante.Name = "gbDatosEstudiante";
            this.gbDatosEstudiante.Padding = new System.Windows.Forms.Padding(10);
            this.gbDatosEstudiante.Size = new System.Drawing.Size(804, 312);
            this.gbDatosEstudiante.TabIndex = 102;
            this.gbDatosEstudiante.TabStop = false;
            this.gbDatosEstudiante.Text = "Datos del Estudiante";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(547, 74);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 49;
            this.dtpFechaIngreso.Tag = "Fecha Ingreso";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(341, 73);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 48;
            this.dtpFechaNacimiento.Tag = "Fecha Nacimiento";
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.txt_obsDet);
            this.gbObservaciones.Controls.Add(this.checkBox6);
            this.gbObservaciones.Controls.Add(this.checkBox5);
            this.gbObservaciones.Controls.Add(this.checkBox4);
            this.gbObservaciones.Controls.Add(this.checkBox3);
            this.gbObservaciones.Controls.Add(this.checkBox2);
            this.gbObservaciones.Controls.Add(this.checkBox1);
            this.gbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbObservaciones.ForeColor = System.Drawing.Color.White;
            this.gbObservaciones.Location = new System.Drawing.Point(13, 199);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(778, 100);
            this.gbObservaciones.TabIndex = 47;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Tag = "Observaciones";
            this.gbObservaciones.Text = "Observaciones";
            // 
            // txt_obsDet
            // 
            this.txt_obsDet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txt_obsDet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_obsDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obsDet.ForeColor = System.Drawing.Color.LightGray;
            this.txt_obsDet.Location = new System.Drawing.Point(271, 19);
            this.txt_obsDet.Multiline = true;
            this.txt_obsDet.Name = "txt_obsDet";
            this.txt_obsDet.Size = new System.Drawing.Size(273, 72);
            this.txt_obsDet.TabIndex = 35;
            this.txt_obsDet.Tag = "Detalles";
            this.txt_obsDet.Text = "Detalles\r\n";
            this.txt_obsDet.Enter += new System.EventHandler(this.VaciarTexto);
            this.txt_obsDet.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(139, 73);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(102, 20);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(139, 47);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(102, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(139, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(102, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(102, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidadEstudiante
            // 
            this.cmbNacionalidadEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbNacionalidadEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNacionalidadEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidadEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.cmbNacionalidadEstudiante.ItemHeight = 15;
            this.cmbNacionalidadEstudiante.Items.AddRange(new object[] {
            "argentina",
            "uruguay",
            "peru",
            "chile"});
            this.cmbNacionalidadEstudiante.Location = new System.Drawing.Point(15, 165);
            this.cmbNacionalidadEstudiante.Name = "cmbNacionalidadEstudiante";
            this.cmbNacionalidadEstudiante.Size = new System.Drawing.Size(210, 23);
            this.cmbNacionalidadEstudiante.TabIndex = 46;
            this.cmbNacionalidadEstudiante.Tag = "Nacionalidad";
            this.cmbNacionalidadEstudiante.Text = "Nacionalidad";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.ForeColor = System.Drawing.Color.LightGray;
            this.cmbTurno.ItemHeight = 15;
            this.cmbTurno.Items.AddRange(new object[] {
            "mañana",
            "tarde"});
            this.cmbTurno.Location = new System.Drawing.Point(231, 165);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(104, 23);
            this.cmbTurno.TabIndex = 45;
            this.cmbTurno.Tag = "Turno";
            this.cmbTurno.Text = "Turno";
            // 
            // cmbCaracterizacion
            // 
            this.cmbCaracterizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbCaracterizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCaracterizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaracterizacion.ForeColor = System.Drawing.Color.LightGray;
            this.cmbCaracterizacion.ItemHeight = 15;
            this.cmbCaracterizacion.Items.AddRange(new object[] {
            "Neuromotora",
            "D. Intelectual",
            "D. Visual",
            "Sordo",
            "TEL",
            "ADYCS",
            "Sordoceguera",
            "Multidiscapacidad"});
            this.cmbCaracterizacion.Location = new System.Drawing.Point(125, 73);
            this.cmbCaracterizacion.Name = "cmbCaracterizacion";
            this.cmbCaracterizacion.Size = new System.Drawing.Size(210, 23);
            this.cmbCaracterizacion.TabIndex = 39;
            this.cmbCaracterizacion.Tag = "Caracterizacion";
            this.cmbCaracterizacion.Text = "Caracterizacion";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.ForeColor = System.Drawing.Color.LightGray;
            this.cmbCategoria.ItemHeight = 15;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Lactantes",
            "deambulante",
            "2 años"});
            this.cmbCategoria.Location = new System.Drawing.Point(15, 73);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(104, 23);
            this.cmbCategoria.TabIndex = 38;
            this.cmbCategoria.Tag = "Categoria";
            this.cmbCategoria.Text = "Categoria";
            // 
            // cmbLocalidadEstudiante
            // 
            this.cmbLocalidadEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbLocalidadEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocalidadEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidadEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.cmbLocalidadEstudiante.IntegralHeight = false;
            this.cmbLocalidadEstudiante.ItemHeight = 15;
            this.cmbLocalidadEstudiante.Items.AddRange(new object[] {
            "glew",
            "ale korn",
            "guernica"});
            this.cmbLocalidadEstudiante.Location = new System.Drawing.Point(447, 136);
            this.cmbLocalidadEstudiante.Name = "cmbLocalidadEstudiante";
            this.cmbLocalidadEstudiante.Size = new System.Drawing.Size(210, 23);
            this.cmbLocalidadEstudiante.TabIndex = 37;
            this.cmbLocalidadEstudiante.Tag = "Localidad";
            this.cmbLocalidadEstudiante.Text = "Localidad";
            // 
            // txtDireccionEstudiante
            // 
            this.txtDireccionEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtDireccionEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.txtDireccionEstudiante.Location = new System.Drawing.Point(15, 137);
            this.txtDireccionEstudiante.Name = "txtDireccionEstudiante";
            this.txtDireccionEstudiante.Size = new System.Drawing.Size(210, 22);
            this.txtDireccionEstudiante.TabIndex = 36;
            this.txtDireccionEstudiante.Tag = "Direccion";
            this.txtDireccionEstudiante.Text = "Direccion";
            this.txtDireccionEstudiante.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtDireccionEstudiante.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtEntreCallesEstudiante
            // 
            this.txtEntreCallesEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtEntreCallesEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntreCallesEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntreCallesEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.txtEntreCallesEstudiante.Location = new System.Drawing.Point(231, 137);
            this.txtEntreCallesEstudiante.Name = "txtEntreCallesEstudiante";
            this.txtEntreCallesEstudiante.Size = new System.Drawing.Size(210, 22);
            this.txtEntreCallesEstudiante.TabIndex = 34;
            this.txtEntreCallesEstudiante.Tag = "Entre Calles";
            this.txtEntreCallesEstudiante.Text = "Entre Calles";
            this.txtEntreCallesEstudiante.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtEntreCallesEstudiante.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtCuil
            // 
            this.txtCuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtCuil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuil.ForeColor = System.Drawing.Color.LightGray;
            this.txtCuil.Location = new System.Drawing.Point(15, 40);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(210, 22);
            this.txtCuil.TabIndex = 33;
            this.txtCuil.Tag = " CUIL";
            this.txtCuil.Text = " CUIL";
            this.txtCuil.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtCuil.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtApellidosEstudiante
            // 
            this.txtApellidosEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtApellidosEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidosEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.txtApellidosEstudiante.Location = new System.Drawing.Point(447, 40);
            this.txtApellidosEstudiante.Name = "txtApellidosEstudiante";
            this.txtApellidosEstudiante.Size = new System.Drawing.Size(210, 22);
            this.txtApellidosEstudiante.TabIndex = 2;
            this.txtApellidosEstudiante.Tag = " Apellidos";
            this.txtApellidosEstudiante.Text = " Apellidos";
            this.txtApellidosEstudiante.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtApellidosEstudiante.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtNombresEstudiante
            // 
            this.txtNombresEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtNombresEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresEstudiante.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombresEstudiante.Location = new System.Drawing.Point(231, 40);
            this.txtNombresEstudiante.Name = "txtNombresEstudiante";
            this.txtNombresEstudiante.Size = new System.Drawing.Size(210, 22);
            this.txtNombresEstudiante.TabIndex = 1;
            this.txtNombresEstudiante.Tag = " Nombres";
            this.txtNombresEstudiante.Text = " Nombres";
            this.txtNombresEstudiante.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtNombresEstudiante.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.ForeColor = System.Drawing.Color.LightGray;
            this.cmbGenero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbGenero.ItemHeight = 15;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(663, 40);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(104, 23);
            this.cmbGenero.TabIndex = 31;
            this.cmbGenero.Tag = "Genero";
            this.cmbGenero.Text = "Genero";
            // 
            // gbDatosResponsable
            // 
            this.gbDatosResponsable.Controls.Add(this.cmbParentesco);
            this.gbDatosResponsable.Controls.Add(this.btnRegistrar);
            this.gbDatosResponsable.Controls.Add(this.btn_altaCancel);
            this.gbDatosResponsable.Controls.Add(this.txtTelefono2);
            this.gbDatosResponsable.Controls.Add(this.txtTelefono1);
            this.gbDatosResponsable.Controls.Add(this.txtOcupacion);
            this.gbDatosResponsable.Controls.Add(this.cmbNacionalidadResponsable);
            this.gbDatosResponsable.Controls.Add(this.cmbLocalidadResponsable);
            this.gbDatosResponsable.Controls.Add(this.txtDireccionResponsable);
            this.gbDatosResponsable.Controls.Add(this.txtDNI);
            this.gbDatosResponsable.Controls.Add(this.txtApellidosResponsable);
            this.gbDatosResponsable.Controls.Add(this.txtNombresResponsable);
            this.gbDatosResponsable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatosResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosResponsable.ForeColor = System.Drawing.Color.White;
            this.gbDatosResponsable.Location = new System.Drawing.Point(10, 322);
            this.gbDatosResponsable.Name = "gbDatosResponsable";
            this.gbDatosResponsable.Padding = new System.Windows.Forms.Padding(10);
            this.gbDatosResponsable.Size = new System.Drawing.Size(804, 238);
            this.gbDatosResponsable.TabIndex = 103;
            this.gbDatosResponsable.TabStop = false;
            this.gbDatosResponsable.Text = "Datos del responsable";
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbParentesco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbParentesco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbParentesco.ForeColor = System.Drawing.Color.LightGray;
            this.cmbParentesco.ItemHeight = 15;
            this.cmbParentesco.Items.AddRange(new object[] {
            "Madre",
            "Padre",
            "Otro"});
            this.cmbParentesco.Location = new System.Drawing.Point(12, 135);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(210, 23);
            this.cmbParentesco.TabIndex = 53;
            this.cmbParentesco.Tag = "Parentesco";
            this.cmbParentesco.Text = "Parentesco";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Location = new System.Drawing.Point(620, 144);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(181, 56);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Tag = "Registrar";
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btn_altaCancel
            // 
            this.btn_altaCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_altaCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_altaCancel.Location = new System.Drawing.Point(476, 153);
            this.btn_altaCancel.Name = "btn_altaCancel";
            this.btn_altaCancel.Size = new System.Drawing.Size(131, 39);
            this.btn_altaCancel.TabIndex = 51;
            this.btn_altaCancel.Tag = "Cancelar";
            this.btn_altaCancel.Text = "Cancelar";
            this.btn_altaCancel.UseVisualStyleBackColor = false;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono2.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelefono2.Location = new System.Drawing.Point(444, 97);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(210, 22);
            this.txtTelefono2.TabIndex = 50;
            this.txtTelefono2.Tag = "Telefono 2";
            this.txtTelefono2.Text = "Telefono 2";
            this.txtTelefono2.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtTelefono2.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono1.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelefono1.Location = new System.Drawing.Point(228, 97);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(210, 22);
            this.txtTelefono1.TabIndex = 49;
            this.txtTelefono1.Tag = "Telefono 1";
            this.txtTelefono1.Text = "Telefono 1";
            this.txtTelefono1.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtTelefono1.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.ForeColor = System.Drawing.Color.LightGray;
            this.txtOcupacion.Location = new System.Drawing.Point(12, 97);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(210, 22);
            this.txtOcupacion.TabIndex = 48;
            this.txtOcupacion.Tag = "Ocupacion";
            this.txtOcupacion.Text = "Ocupacion";
            this.txtOcupacion.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtOcupacion.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // cmbNacionalidadResponsable
            // 
            this.cmbNacionalidadResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbNacionalidadResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNacionalidadResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidadResponsable.ForeColor = System.Drawing.Color.LightGray;
            this.cmbNacionalidadResponsable.ItemHeight = 15;
            this.cmbNacionalidadResponsable.Items.AddRange(new object[] {
            "argentina",
            "chile",
            "peru",
            "uruguay"});
            this.cmbNacionalidadResponsable.Location = new System.Drawing.Point(444, 62);
            this.cmbNacionalidadResponsable.Name = "cmbNacionalidadResponsable";
            this.cmbNacionalidadResponsable.Size = new System.Drawing.Size(210, 23);
            this.cmbNacionalidadResponsable.TabIndex = 47;
            this.cmbNacionalidadResponsable.Tag = "Nacionalidad";
            this.cmbNacionalidadResponsable.Text = "Nacionalidad";
            // 
            // cmbLocalidadResponsable
            // 
            this.cmbLocalidadResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.cmbLocalidadResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLocalidadResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocalidadResponsable.ForeColor = System.Drawing.Color.LightGray;
            this.cmbLocalidadResponsable.ItemHeight = 15;
            this.cmbLocalidadResponsable.Items.AddRange(new object[] {
            "glew",
            "ale korn",
            "guernica"});
            this.cmbLocalidadResponsable.Location = new System.Drawing.Point(228, 62);
            this.cmbLocalidadResponsable.Name = "cmbLocalidadResponsable";
            this.cmbLocalidadResponsable.Size = new System.Drawing.Size(210, 23);
            this.cmbLocalidadResponsable.TabIndex = 39;
            this.cmbLocalidadResponsable.Tag = "Localidad";
            this.cmbLocalidadResponsable.Text = "Localidad";
            // 
            // txtDireccionResponsable
            // 
            this.txtDireccionResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtDireccionResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionResponsable.ForeColor = System.Drawing.Color.LightGray;
            this.txtDireccionResponsable.Location = new System.Drawing.Point(12, 63);
            this.txtDireccionResponsable.Name = "txtDireccionResponsable";
            this.txtDireccionResponsable.Size = new System.Drawing.Size(210, 22);
            this.txtDireccionResponsable.TabIndex = 38;
            this.txtDireccionResponsable.Tag = "Direccion";
            this.txtDireccionResponsable.Text = "Direccion";
            this.txtDireccionResponsable.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtDireccionResponsable.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.LightGray;
            this.txtDNI.Location = new System.Drawing.Point(12, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(210, 22);
            this.txtDNI.TabIndex = 36;
            this.txtDNI.Tag = " DNI";
            this.txtDNI.Text = " DNI";
            this.txtDNI.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtDNI.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtApellidosResponsable
            // 
            this.txtApellidosResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtApellidosResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidosResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosResponsable.ForeColor = System.Drawing.Color.LightGray;
            this.txtApellidosResponsable.Location = new System.Drawing.Point(444, 30);
            this.txtApellidosResponsable.Name = "txtApellidosResponsable";
            this.txtApellidosResponsable.Size = new System.Drawing.Size(210, 22);
            this.txtApellidosResponsable.TabIndex = 35;
            this.txtApellidosResponsable.Tag = " Apellidos";
            this.txtApellidosResponsable.Text = " Apellidos";
            this.txtApellidosResponsable.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtApellidosResponsable.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // txtNombresResponsable
            // 
            this.txtNombresResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(136)))), ((int)(((byte)(248)))));
            this.txtNombresResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresResponsable.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombresResponsable.Location = new System.Drawing.Point(228, 30);
            this.txtNombresResponsable.Name = "txtNombresResponsable";
            this.txtNombresResponsable.Size = new System.Drawing.Size(210, 22);
            this.txtNombresResponsable.TabIndex = 34;
            this.txtNombresResponsable.Tag = " Nombres";
            this.txtNombresResponsable.Text = " Nombres";
            this.txtNombresResponsable.Enter += new System.EventHandler(this.VaciarTexto);
            this.txtNombresResponsable.Leave += new System.EventHandler(this.RellenarTexto);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // NuevoEstudianteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(824, 570);
            this.Controls.Add(this.gbDatosResponsable);
            this.Controls.Add(this.gbDatosEstudiante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoEstudianteFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "NuevoEstudianteFrm";
            this.Load += new System.EventHandler(this.NuevoEstudianteFrm_Load);
            this.gbDatosEstudiante.ResumeLayout(false);
            this.gbDatosEstudiante.PerformLayout();
            this.gbObservaciones.ResumeLayout(false);
            this.gbObservaciones.PerformLayout();
            this.gbDatosResponsable.ResumeLayout(false);
            this.gbDatosResponsable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosEstudiante;
        private System.Windows.Forms.TextBox txtEntreCallesEstudiante;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.TextBox txtApellidosEstudiante;
        private System.Windows.Forms.TextBox txtNombresEstudiante;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbCaracterizacion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbLocalidadEstudiante;
        private System.Windows.Forms.TextBox txtDireccionEstudiante;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.ComboBox cmbNacionalidadEstudiante;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.TextBox txt_obsDet;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbDatosResponsable;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btn_altaCancel;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.ComboBox cmbNacionalidadResponsable;
        private System.Windows.Forms.ComboBox cmbLocalidadResponsable;
        private System.Windows.Forms.TextBox txtDireccionResponsable;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidosResponsable;
        private System.Windows.Forms.TextBox txtNombresResponsable;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.ComboBox cmbParentesco;
    }
}