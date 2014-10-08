using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Bidikmisioffline.classes
{
    abstract class SimpleQuery
    {
        public static DataTable get_provinsi()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable provdt = db.GetDataTable("select KODE_PROVINSI, NAMA_PROVINSI from m_provinsi");

            DataRow row  = provdt.NewRow();
            row["KODE_PROVINSI"] = "0";
            row["NAMA_PROVINSI"] = "-- Pilih Provinsi --";
            provdt.Rows.InsertAt(row, 0);

            return provdt;
        }

        public static DataTable get_kota()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable kotadt = db.GetDataTable("select KODE_KOTA, NAMA_KOTA from m_kota");

            DataRow row = kotadt.NewRow();
            row["KODE_KOTA"] = "0";
            row["NAMA_KOTA"] = "-- Pilih Kota --";
            kotadt.Rows.InsertAt(row, 0);

            return kotadt;
        }

        public static DataTable get_kota(String prov)
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable kotadt = db.GetDataTable("select KODE_KOTA, NAMA_KOTA from m_kota where KODE_PROVINSI = "+prov+"");

            DataRow row = kotadt.NewRow();
            row["KODE_KOTA"] = "0";
            row["NAMA_KOTA"] = "-- Pilih Kota --";
            kotadt.Rows.InsertAt(row, 0);

            return kotadt;
        }

        public static DataTable get_listtahunajaran()
        {
            int rekursi = 2;

            SQLiteDatabase db = new SQLiteDatabase();
            String tahun = db.ExecuteScalar("select NILAI_VARIABEL from variabel where NAMA_VARIABEL = 'tahun'");

            DataTable tahundt = new DataTable();
            tahundt.Columns.Add("TAHUN");

            while (rekursi != 0)
            {
                DataRow row = tahundt.NewRow();
                row["TAHUN"] = Int32.Parse(tahun) - rekursi--;
                tahundt.Rows.InsertAt(row, 0);
            }

            return tahundt;
        }

        public static DataTable get_list_pendidikan()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pddkdt = db.GetDataTable("select KODE_PENDIDIKAN, NAMA_PENDIDIKAN from m_pendidikan where STATUS = 1");

            DataRow row = pddkdt.NewRow();
            row["KODE_PENDIDIKAN"] = "0";
            row["NAMA_PENDIDIKAN"] = "-- Pilih Pendidikan --";
            pddkdt.Rows.InsertAt(row, 0);

            return pddkdt;
        }

        public static DataTable get_list_pekerjaan()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pkrjdt = db.GetDataTable("select KODE_PEKERJAAN, NAMA_PEKERJAAN from m_pekerjaan where STATUS = 1");

            DataRow row = pkrjdt.NewRow();
            row["KODE_PEKERJAAN"] = "0";
            row["NAMA_PEKERJAAN"] = "-- Pilih Pekerjaan --";
            pkrjdt.Rows.InsertAt(row, 0);

            return pkrjdt;
        }

        public static DataTable get_list_penghasilan()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pghndt = db.GetDataTable("select KODE_PENGHASILAN, RINCIAN from m_pekerjaan where STATUS = 1");

            DataRow row = pghndt.NewRow();
            row["KODE_PENGHASILAN"] = "0";
            row["NAMA_PENGHASILAN"] = "-- Pilih Penghasilan --";
            pghndt.Rows.InsertAt(row, 0);

            return pghndt;
        }

        /* =============================================================================================== */
        /* ============================================  RUMAH [BEGIN]   ================================= */
        public static DataTable get_list_kepemilikan()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pghndt = db.GetDataTable("select KODE_KEPEMILIKAN, KEPEMILIKAN from m_kepemilikan");

            DataRow row = pghndt.NewRow();
            row["KODE_KEPEMILIKAN"] = "0";
            row["KEPEMILIKAN"] = "-- Pilih Kepemilikan --";
            pghndt.Rows.InsertAt(row, 0);

            return pghndt;
        }

        public static DataTable get_list_listrik()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pghndt = db.GetDataTable("select KODE_LISTRIK, SUMBER from m_listrik where STATUS = 1");

            DataRow row = pghndt.NewRow();
            row["KODE_LISTRIK"] = "0";
            row["SUMBER"] = "-- Pilih Listrik --";
            pghndt.Rows.InsertAt(row, 0);

            return pghndt;
        }

        public static DataTable get_list_luas()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable pghndt = db.GetDataTable("select KODE_LUAS, LUAS from m_luas where STATUS = 1");

            DataRow row = pghndt.NewRow();
            row["KODE_LUAS"] = "0";
            row["LUAS"] = "-- Pilih Luas --";
            pghndt.Rows.InsertAt(row, 0);

            return pghndt;
        }

        public static DataTable get_list_mck()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable dt = db.GetDataTable("select KODE_MCK, MCK from m_mck");

            DataRow row = dt.NewRow();
            row["KODE_MCK"] = "0";
            row["MCK"] = "-- Pilih MCK --";
            dt.Rows.InsertAt(row, 0);

            return dt;
        }
        /* ============================================  RUMAH [END]   ================================= */
        /* =============================================================================================== */
    }
}
