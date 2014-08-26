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
    }
}
