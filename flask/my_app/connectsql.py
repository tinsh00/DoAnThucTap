import pyodbc
from flask import Flask,render_template,url_for, request, redirect, flash, jsonify,json
import requests


app = Flask(__name__)
app.sercret_key = "flash_message"

def read(conn):
    print("Read:")
    cursor = conn.cursor();
    cursor.execute("select * from BienSoXe")
    for row in cursor:
        print(f'row = {row}')
    print()
conn = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"
    "Server=DESKTOP-HV66NF2;"
    "Database=BIENSOXE;"
    "Trusted_Connection=yes;"
)
cursor = conn.cursor()

read(conn)

#@app.route("/add", methods=["GET"])
#def starting_url():
#    json_data = flask.request.json
#    a_value = json_data["a_key"]
#    return "JSON value sent: " + a_value



@app.route('/add')
def add():
    if request.method =='POST':
        productDetails= request.body
        ID= productDetails.get('id')
        BIENSO=productDetails.get('BienSo')
        THOIGIAN= productDetails.get('ThoiGian')
        TRANGTHAI= productDetails.get('TrangThai')
        create_row_data = { 'id':id, 'BienSo':BIENSO,
                            'ThoiGian':THOIGIAN, 'TrangThai':TRANGTHAI }
        info = requests.post('http://localhost:5000/add', data= create_row_data)
        return info.text   #return(render_template('product.html'))
    else:
        return (render_template('add.html'))

if __name__=='__main__':
    app.run(debug=True, port="0.0.0.0")
