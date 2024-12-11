using NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N.clases;
using NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N.clases.herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N
{
    public partial class Form1 : Form
    {

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_transferencia_entre_archivos = var_fun_GG.GG_caracter_para_transferencia_entre_archivos;
        string[] G_caracter_usadas_por_usuario = var_fun_GG.GG_caracter_usadas_por_usuario;

        int G_donde_inicia_la_tabla = var_fun_GG.GG_indice_donde_comensar;

        public string[] G_dir_arch_transferencia = var_fun_GG.GG_dir_arch_transferencia;
        

        Tex_base bas = new Tex_base();
        conmutador con = new conmutador();


        public Form1()
        {
            InitializeComponent();
            poner_al_inicio_del_programa funcion_inicio = new poner_al_inicio_del_programa();
            funcion_inicio.inicio();
        }

        private async void btn_proceso_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    await Task.Run(() => datos_a_procesar_y_borrar());
                    await Task.Delay(1000); // Pausa de 1 segundo entre iteraciones
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores si es necesario
                Console.WriteLine($"Error: {ex.Message}");
            }
        }



        private void datos_a_procesar_y_borrar()
        {
            
            string[] usuarios_lectura = bas.Leer(G_dir_arch_transferencia[2]);

            if (usuarios_lectura[0] == var_fun_GG.GG_id_programa || usuarios_lectura[0] == "")
            {

                string[] respuestas_ia = bas.Leer(G_dir_arch_transferencia[1]);

                if (respuestas_ia.Length > 1)
                {


                    for (int i = G_donde_inicia_la_tabla; i < respuestas_ia.Length; i++)
                    {
                        string[] id_programa_comparar = respuestas_ia[i].Split(G_caracter_para_transferencia_entre_archivos[0][0]);
                        if (usuarios_lectura[0] == var_fun_GG.GG_id_programa || usuarios_lectura[0] == "")
                        {
                            con.conmutar_proceso_recibido(id_programa_comparar[1]);
                        }


                    }
                    bas.eliminar_fila_PARA_MULTIPLES_PROGRAMAS(G_dir_arch_transferencia[1], 0, var_fun_GG.GG_id_programa, G_caracter_para_transferencia_entre_archivos[0]);
                    //bas.cambiar_archivo_con_arreglo(G_dir_arch_transferencia[id_atras_actual_adelante_2[1]], new string[] { "sin_informacion" });
                }


                cambiar_id_programa_al_siguiente(usuarios_lectura);

            }


        }

        public void cambiar_id_programa_al_siguiente(string[] usuarios)
        {

            if (usuarios[0] == var_fun_GG.GG_id_programa)
            {
                int id_nuevo = 0;
                for (int i = G_donde_inicia_la_tabla; i < usuarios.Length; i++)
                {
                    if (usuarios[i] == var_fun_GG.GG_id_programa)
                    {
                        if (i >= (usuarios.Length - 1))
                        {
                            id_nuevo = 1;
                            break;
                        }
                        else
                        {
                            id_nuevo = i + 1;
                            break;
                        }
                    }
                }
                if (usuarios.Length > 2)
                {
                    bas.Editar_fila_espesifica_SIN_ARREGLO_GG(G_dir_arch_transferencia[2], 0, usuarios[id_nuevo]);
                }


            }

        }

        private void btn_env_com_Click(object sender, EventArgs e)
        {
            con.enviar_a_serv(txt_comando.Text);
        }


        //fin clase--------------------------------------------
    }
}
