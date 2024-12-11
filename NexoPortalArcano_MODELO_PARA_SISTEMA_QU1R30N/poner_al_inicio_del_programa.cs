using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N.clases;
using NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N.clases.herramientas;

namespace NexoPortalArcano_MODELO_PARA_SISTEMA_QU1R30N
{
    internal class poner_al_inicio_del_programa
    {
        Tex_base bas = new Tex_base();
        operaciones_arreglos op_arreglos = new operaciones_arreglos();

        int G_configuracion = var_fun_GG.GG_indice_donde_comensar;
        string[] G_caracter_separacion = var_fun_GG.GG_caracter_separacion;
        string[] G_separador_para_funciones_espesificas_ = var_fun_GG.GG_caracter_separacion_funciones_espesificas;

        string G_id_programa = var_fun_GG.GG_id_programa;

        int G_donde_inicia_tabla = var_fun_GG.GG_indice_donde_comensar;

        public string[] G_dir_arch_transferencia = var_fun_GG.GG_dir_arch_transferencia;
        


        public void inicio()
        {

            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(G_dir_arch_transferencia[0], "sin informacion");
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(G_dir_arch_transferencia[1], "sin informacion");
            bas.Crear_archivo_y_directorio_opcion_leer_y_agrega_arreglo(G_dir_arch_transferencia[2], G_id_programa + "\n" + G_id_programa);


            string[] inf_arc = bas.Leer(G_dir_arch_transferencia[2]);

            if (inf_arc == null)
            {
                bas.Agregar(G_dir_arch_transferencia[2], var_fun_GG.GG_id_programa + "\n" + var_fun_GG.GG_id_programa);
            }
            else if (inf_arc.Length == 1 && inf_arc[2] == "")
            {
                bas.Agregar(G_dir_arch_transferencia[2], var_fun_GG.GG_id_programa + "\n" + var_fun_GG.GG_id_programa);
            }
            else if (inf_arc.Length == 0)
            {
                bas.Agregar(G_dir_arch_transferencia[2], var_fun_GG.GG_id_programa + "\n" + var_fun_GG.GG_id_programa);
            }
            else
            {
                bas.Agregar_sino_existe(G_dir_arch_transferencia[2], 0, var_fun_GG.GG_id_programa, var_fun_GG.GG_id_programa);
            }


        }


        //FIN CLASE---------------------------------------------------------
    }
}
