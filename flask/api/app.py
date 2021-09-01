from flask import Flask, jsonify,abort,request
import pyodbc
import pandas as pd
from datetime import datetime
import json
import decimal

hientai = datetime.now()
timestamp1 = round(datetime.timestamp(hientai),0)
timestamp=int(timestamp1)



app = Flask(__name__)

conn = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"
    "Server=DESKTOP-HV66NF2;"
    "Database=BIENSOXE;"
    "Trusted_Connection=yes;"
)
cursor = conn.cursor()

#####################BSX NGÀY#######################################

@app.route('/api/getBSX', methods=['GET'])
def get_BSX():
    SQL_Query = pd.read_sql_query(
    '''select * from XeTheoNgay''', conn)
    df = pd.DataFrame(SQL_Query, columns=['ID','BienSo','ThoiGian','TrangThai'])
    result = df.to_json(orient="records")
    return result

#Get1
@app.route('/api/getBSX/<string:bienso>', methods=['GET'])
def get_1_BSX(bienso):
    SQL_QueryGet1 = pd.read_sql_query(
    "select * from XeTheoNgay Where BienSo = '"+ bienso +"'", conn)
    df1 = pd.DataFrame(SQL_QueryGet1, columns=['ID','BienSo','ThoiGian','TrangThai'])
    result1 = df1.to_json(orient="records")
    return result1

#POST
@app.route('/api/post', methods=['POST'])
def create_task():
    data = request.json
    cursor.execute("INSERT INTO XeTheoNgay( BienSo, ThoiGian, TrangThai) VALUES(?, ?, ?)",(data["BienSo"],data["ThoiGian"],data["TrangThai"]))
    conn.commit()
    return  data,201

#Sửa 1 field
@app.route('/api/post/update', methods=['POST'])
def create_task_update():
    data = request.json
    cursor.execute(" UPDATE XeTheoNgay SET BienSo = ?,TrangThai= ? WHERE ID= ?",(data["BienSo"],data["TrangThai"],data["ID"]));
    conn.commit()
    return  data,201
#update 0
@app.route('/api/post/updateTT', methods=['POST'])
def create_task_updateTT():
    data = request.json
    cursor.execute(" exec SP_CheckIn ?,?",(data["BienSo"],data["ThoiGian"]));
    conn.commit()
    return  data,201

#Delete 1 field
@app.route('/api/post/delete', methods=['POST'])
def delete_task():
    data = request.json
    cursor.execute(" Delete XeTheoNgay WHERE ID= ?",(data["ID"]));
    conn.commit()
    return  data,201


##############Ư USER##########################
@app.route('/api/getAllUser', methods=['GET'])
def get_All_User():
    SQL_Query1 = pd.read_sql_query(
    '''select * from UserTable''', conn)
    df1 = pd.DataFrame(SQL_Query1, columns=['ID','HoTen','GioiTinh','NgaySinh','SDT','Email','NgayDK','TrangThai'])
    result1 = df1.to_json(orient="records")
    return result1

#Get1
@app.route('/api/getOneUser/<string:email>', methods=['GET'])
def get_1_User(email):
    SQL_QueryGet1 = pd.read_sql_query(
    "select * from UserTable Where  Email = '"+ email +"'" ,conn)
    df1 = pd.DataFrame(SQL_QueryGet1, columns=['ID','HoTen','GioiTinh','NgaySinh','SDT','Email','NgayDK','TrangThai'])
    result1 = df1.to_json(orient="records")
    return result1

# kiemtra ben xe co khong, co thi cho qua, khong co thi qua ben biensoxe, neu co thi cho tt=1, neu tt=1 thì chuyen sang 0
@app.route('/api/soatthexe/<string:soxe>', methods=['GET'])
def update_soat_the_xe(soxe):
    SQL_QueryGet1 = pd.read_sql_query(
    "select * from XeTable Where  SoXe = '"+ soxe +"'" ,conn)
    df1 = pd.DataFrame(SQL_QueryGet1,columns=['ID','IDUser','IDHang','IDLoai','SoXe','MauXe'])
    result1 = df1.to_json(orient="records")
    return result1,201



#POST
@app.route('/api/postUser', methods=['POST'])
def create_User():
    data = request.json
    cursor.execute("INSERT INTO UserTable(HoTen, GioiTinh,NgaySinh,SDT,Email,NgayDK, TrangThai) VALUES(?, ?, ?, ?,?,?,?)",(data["HoTen"],data["GioiTinh"],data["NgaySinh"],data["SDT"],data["Email"],data["NgayDK"],data["TrangThai"]))
    conn.commit()
    return  data,201

#Sửa 1 field
@app.route('/api/post/updateUser', methods=['POST'])
def create_task_updateUser():
    data = request.json
    cursor.execute(" UPDATE UserTable SET HoTen = ?,GioiTinh = ?,NgaySinh = ?,SDT =?,Email = ?, NgayDK = ?, TrangThai= ? WHERE ID= ?",(data["HoTen"],data["GioiTinh"],data["NgaySinh"],data["SDT"],data["Email"],data["NgayDK"],data["TrangThai"],data["ID"]));
    conn.commit()
    return  data,201

#Delete 1 field
@app.route('/api/post/deleteUser', methods=['POST'])
def delete_User():
    data = request.json
    cursor.execute(" Delete UserTable WHERE ID= ?",(data["ID"]));
    conn.commit()
    return  data,201

####################LoaiXe#################################
@app.route('/api/getLoaiXe', methods=['GET'])
def get_All_LoaiXe():
    SQL_Query1 = pd.read_sql_query(
    '''select * from LoaiXe''', conn)
    df1 = pd.DataFrame(SQL_Query1, columns=['ID','Loai'])
    result1 = df1.to_json(orient="records")
    return result1

#POST
@app.route('/api/postLoaiXe', methods=['POST'])
def create_task_LoaiXe():
    data = request.json
    cursor.execute("INSERT INTO LoaiXe(Loai) VALUES(?)",(data["Loai"]))
    conn.commit()
    return  data,201

#Update
@app.route('/api/updateLoaiXe', methods=['POST'])
def update_task_LoaiXe():
    data = request.json
    cursor.execute("UPDATE  LoaiXe SET Loai = ? WHERE ID = ?",(data["Loai"],data["ID"]))
    conn.commit()
    return  data,201

#Delete 1 field
@app.route('/api/deleteLoaiXe', methods=['POST'])
def delete_task_LoaiXe():
    data = request.json
    cursor.execute(" Delete LoaiXe WHERE ID= ?",(data["ID"]));
    conn.commit()
    return  data,201

#################HANGXE#########################
@app.route('/api/getHangXe', methods=['GET'])
def get_All_HangXe():
    SQL_Query1 = pd.read_sql_query(
    '''select * from HangXe''', conn)
    df1 = pd.DataFrame(SQL_Query1, columns=['ID','Hang'])
    result1 = df1.to_json(orient="records")
    return result1

#POST
@app.route('/api/postHangXe', methods=['POST'])
def create_task_HangXe():
    data = request.json
    cursor.execute("INSERT INTO HangXe(Hang) VALUES(?)",(data["Hang"]))
    conn.commit()
    return  data,201

#Update
@app.route('/api/updateHangXe', methods=['POST'])
def update_task_HangXe():
    data = request.json
    cursor.execute("UPDATE  HangXe SET Hang = ? WHERE ID = ?",(data["Hang"],data["ID"]))
    conn.commit()
    return  data,201

#Delete 1 field
@app.route('/api/deleteHangXe', methods=['POST'])
def delete_task_HangXe():
    data = request.json
    cursor.execute(" Delete HangXe WHERE ID= ?",(data["ID"]));
    conn.commit()
    return  data,201

##################XE####################################
@app.route('/api/getXe', methods=['GET'])
def get_All_Xe():
    SQL_Query1 = pd.read_sql_query(
    '''select * from XeTable''', conn)
    df1 = pd.DataFrame(SQL_Query1, columns=['ID','IDUser','IDHang','IDLoai','SoXe','MauXe'])
    result1 = df1.to_json(orient="records")
    return result1
#POST
@app.route('/api/postXe', methods=['POST'])
def create_task_Xe():
    data = request.json
    cursor.execute("INSERT INTO XeTable(IDUser,IDHang,IDLoai,SoXe,MauXe) VALUES(?,?,?,?,?)",(data["IDUser"],data["IDHang"],data["IDLoai"],data["SoXe"],data["MauXe"]))
    conn.commit()
    return  data,201

#Update
@app.route('/api/updateXe', methods=['POST'])
def update_task_Xe():
    data = request.json
    cursor.execute("UPDATE  XeTable SET SoXe = ?,MauXe=? WHERE ID = ?",(data["SoXe"],data["MauXe"],data["ID"]))
    conn.commit()
    return  data,201

#Delete 1 field
@app.route('/api/deleteXe', methods=['POST'])
def delete_task_Xe():
    data = request.json
    cursor.execute(" Delete XeTable WHERE ID= ?",(data["ID"]));
    conn.commit()
    return  data,201


@app.route('/')
def index():
    return "Hello, World!"

if __name__ == '__main__':
    app.run(debug=True)
