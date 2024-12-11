using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using System.Drawing;
using System.Threading;



namespace NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N.clases.herramientas
{
    internal class conmutador
    {

        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_caracter_separacion_funciones_espesificas = var_fun_GG.GG_caracter_separacion_funciones_espesificas;
        string[] G_caracter_para_confirmacion_o_error = var_fun_GG.GG_caracter_para_confirmacion_o_error;
        string[] G_caracter_para_transferencia_entre_archivos = var_fun_GG.GG_caracter_para_transferencia_entre_archivos;
        string[] G_caracter_usadas_por_usuario = var_fun_GG.GG_caracter_usadas_por_usuario;

        string[] G_caracter_para_usar_como_enter_y_nuevo_mensaje = var_fun_GG.GG_caracter_para_usar_como_enter_y_nuevo_mensaje;


        operaciones_arreglos op_arr = new operaciones_arreglos();
        operaciones_textos op_tex = new operaciones_textos();
        var_fun_GG vf_GG = new var_fun_GG();
        Tex_base bas = new Tex_base();


        public string[] G_dir_arch_transferencia = var_fun_GG.GG_dir_arch_transferencia;
        






        //procesos------------------------------------------------------------------
        public void conmutar_proceso_recibido(string parametro)
        {
            string[] proceso_datos = parametro.Split(G_caracter_para_transferencia_entre_archivos[1][0]);

            switch (proceso_datos[0])
            {
                case "prueba1":
                    break;
                default:
                    break;
            }
        }

        public void enviar_a_serv(string info,  string programa_enviar = "CLASE_QU1R30N")
        {
            
            string info_a_env = programa_enviar + G_caracter_para_transferencia_entre_archivos[0] + var_fun_GG.GG_id_programa + G_caracter_para_transferencia_entre_archivos[1] + info;
            bas.Agregar_a_archivo_sin_arreglo(G_dir_arch_transferencia[0], info_a_env);

        }




        //fin de la clase-------------------------------------------------------------------------------
    }

}
