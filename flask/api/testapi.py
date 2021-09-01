
from datetime import datetime

now = datetime.now()
date = now.strftime("%m/%d/%Y")
dataBSX = {"ThoiGian":date}
print(dataBSX)
