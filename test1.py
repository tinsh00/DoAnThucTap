import cv2
#lấy hình ảnh từ camera đầu tiên
cap = cv2.VideoCapture(0)
while(cap.isOpened()):
    #Đọc video
    ret, frame = cap.read()
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    #Hiển thị video đen trắng
    cv2.imshow('frame',gray)
    if cv2.waitKey(1) & 0xFF == ord('q'):

        break
cap.release()
cv2.destroyAllWindows()
