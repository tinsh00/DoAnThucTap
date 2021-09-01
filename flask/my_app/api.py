from flask import Flask, request, render_template,url_for, redirect, flash
from flask_restplus import Api, Resource
from flask import jsonify
import pyodbc
import requests


 flask_app = Flask(__name__)
 api = Api(app=flask_app)

 class BienSoXe(Resource):
     def get(self,id=None,page=1):
         if

     def post(self):
          productDetails= request.body
          ID= productDetails.get('id')
          BIENSO=productDetails.get('BienSo')
          THOIGIAN= productDetails.get('ThoiGian')
          TRANGTHAI= productDetails.get('TrangThai')
          cursor = conn.cursor()
          cursor.execute("INSERT INTO BienSo(id, BienSo, ThoiGian, TrangThai) VALUES(?, ?, ?, ?)
                         ",(ID,BIENSO,THOIGIAN,TRANGTHAI))
          conn.commit()
          resp = jsonify('User added successfully!')
          resp.status_code = 200
          return resp

api.add_resource(BienSoXe , '/add',methods=['GET', 'POST'])

if __name__ == '__main__':
    flask_app.run(debug=True)
