using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.Trees
{
    public class TreeInvoker
    {
        public static void Invoke()
        {
            //List<char[]> c = new List<char[]>() {
            //  new char[]  {'G','I','Z'},
            //  new char[]        {'U','E','K'},
            //           new char[] {'Q','S','E'}
            //};
            //List<char[]> c = new List<char[]>() {
            //  new char[]  {'R','L','D'},
            //  new char[]        {'U','O','E'},
            //           new char[] {'C','S','O'}
            //};
            //List<char[]> c = new List<char[]>() {
            //  new char[]  {'G','T'},
            //  new char[]  {'O','A'}//,
            //       //    new char[] {'Q','S','E'}
            //};      

            //var res1 = WordBoggel.wordBoggel(c.ToArray(),
            // //new string[] { "GO", "GOAT"});
            // new string[] { "CODE", "SOLO", "RULES", "COOL" });

            //foreach (var item in res1)
            //{
            //    Console.WriteLine(item);
            //}

            //return;

            // IsValidBSTTreeInvoker();

            //Console.WriteLine(INVERSIONS.Cal(new List<int>() { 2, 4, 1, 3, 5 })); ;

            //var res1 =   OrderOfPeopleHeights.Cal(new List<int>() { 86, 92, 49, 21, 62, 27, 90, 59 }, new List<int>() { 2, 0, 0, 2, 0, 2, 1, 3 });
            //  foreach (var item in res1)
            //  {
            //      Console.WriteLine(item);
            //  }

            //return;

             var res2=   ShortestuniquePrefixII.prefix(new List<string>() { "zebra", "dog", "duck", "dot" });
            Console.WriteLine(string.Join(", ", res2.ToArray()));
            return;
            var res = HotelReviewsII.BuildTrie(new List<string>() {
                "euiozio_uoz_qt_hw_uroqr_qwcvlx_ipodi_spqnzo_cwva_t_rgdf_y_tkwwq_t_iuu_vga_hfshc_xhuuyy_tgdglf_ieb_ut_eunfh_axphbs_wztp_jn_jnc_xrjvbv_cef_bemg_dym_mmkw_ehfkr_qbyv_cmpes_omdxl_ubr_yes_qlzmr_wqnk_itxgii_q_sk_tcznlt_rxbltz_dyzva_nkixjw_ztdjp_suow_v_ccock_rjbfrjp_gd_dr_dnp_srjgdr_rv_tv_pazh_t_qvcclpe_tsjpy_zf_otqpoxm_hhwewnv_bvdk_zififr_wqqeoj_eqbnsk_zeew_k_oj_rs_gsczvhh_jzum_g_fhw_k_flu_z_ctka_x_smfa_wins_lsojtrx_wm_l_bypec_eiw_s_neuiqu_pgugwg_mikdwi_k_il",
            "hd_iqed_ngwg_ooupne_k_dg_mhhd_qb_qrfpd_s_khb_tsn_wjp_gde_bjg_dyf_ecqqn_emkimip_cehlbt_bwnkd_ymec_s_hvkm_w_xesho_hml_v_iljv_llfpn_zywcpam_vwtyg_phif_bttnwnp_dby_wodclr_prseqw_d_svyncg_razz_odggxw_b_jqujrm_dpomjr_ledhu_hwk_zktn_ytgjpmm_v_jcnjgzu_wqq_ldzcs_ojswrqc_bqyxaag_bpvtx_onpea_hn_oh_vo_ldxh_prngs_qdjfqt_xyr_izz_eowa_ezdlmw_fcoz_qciew_kek_grc_vzs_hpszob_ix_xk_i_lqlj_kvnbi_pdkyebc_lfkff_lzzmkvm_nl_ivwhwzt_rb_j_rtu_txfkidx_oafye_yvizvoz_qor_mqles_xr_erzo_wrv_pmi_h"}, "qghu_eay_nl_dxfi_cvsc_gg_wk_nqdu_wf_fozv_rtk_pr_p_g_rp_rvys_mwcy_y_c_pev_kef_mz_imkk_svw_r_nzk_cxf_tl_gyp_fad_oo_fxz_co_juv_vabo_gpo_ylf_bnpl_vrvi_ya_yeh_q_qrqp_x_j_loov_o_u_wh_s_cb_coks_zkva_xdkn_yj_h_ixjs_nkk_f_ux_zr_bmnm_q_oke_ly_nk_aug_qrcd_iute_ojw_yyz_vs_m_sa_lfvg_b_aaov_zy_nt_kdcp_s_te_j_hdi_co_zc_fw_qi_tv_wvxh");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }


        }
        public static void IsValidBSTTreeInvoker()
        {
            TreeNode root = new TreeNode();
            root.val = 1;

            //root.left =  new TreeNode() { val = 2, left = new TreeNode() { val = 4 }, right= new TreeNode() { val = 5 } };
            //root.right = new TreeNode() { val = 3, left = new TreeNode() { val = 6 }, right = new TreeNode() { val = 7 } };
            root.left = new TreeNode() { val = 2 };
            root.right = new TreeNode() { val = 3, left = new TreeNode() { val = 4 }, right = new TreeNode() { val = 5 } };
            Console.WriteLine(LeastCommonAncestor.FindLCA(root, 4, 5));

            //Console.WriteLine(ValidBinarySearchTree.IsValidBST(root));
            //Console.WriteLine(MaxDepthOfBinaryTree.FindMaxDepth(root));
            //Console.WriteLine(MinDepthOfBinaryTree.FindMinDepth(root));

            // InvertTheBinaryTree.Invert(root);

            // Console.WriteLine(IdenticalBinaryTrees.IsIdentical(root, root));

            //List<int> nodes = PreOrderTraversal.Traverse(root);

            // List<int> nodes = PostorderTraversal.Traverse(root);
            //List<int> nodes = InOrderTraversal.Traverse(root);


            //foreach (var item in nodes)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(KthSmallestElementInTree.Find(root, 4));

            //var r= ZigZagLevelOrderTraversalBT.Traverse(root);

            //Console.WriteLine(SymmetricBinaryTree.IsSymmetric(root.left, root.right));
        }
    }
}
