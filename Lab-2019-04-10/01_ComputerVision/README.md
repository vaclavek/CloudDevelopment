# CloudDevelopment
## Cognitive Services - Computer Vision [(docs)](https://azure.microsoft.com/cs-cz/services/cognitive-services/computer-vision/), [(API)](https://westcentralus.dev.cognitive.microsoft.com/docs/services/5adf991815e1060e6355ad44/operations/56f91f2e778daf14a499e1fa)

*Tasks*
1. Make/find a photo and make an analysis of content of image.
1. Make/find a real-world photo with some text on it and try to parse the text.
1. Make/find a photo and let the cloud detect more informations (age, gender, hair color, emotions)

## Task 1 - Image analysis ([online example](https://azure.microsoft.com/cs-cz/services/cognitive-services/computer-vision/#analyze))

1. Find Cognitive Services in Azure Portal

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_1_portal.png)

2. Add new Computer images processing service

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_2_portal.png)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_3_portal.png)

3. Find and copy your generated keys

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_4_portal.png)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_5_keys.png)

4. Use [attached application](https://github.com/vaclavek/CloudDevelopment/tree/master/Lab-2019-04-10/01_ComputerVision/01_ImageObjectsAnalysis), insert your own subscription key and run application

5.  Processed image (use your own)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_6_image.jpg)

6.  Look at the results:

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_7_result.png)

7.  You can see your request in Azure portal

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_8_graph.png)

## Task 2 - Text analysis on the image ([online example](https://azure.microsoft.com/cs-cz/services/cognitive-services/computer-vision/#text)), [HTML wireframe analysis - video](https://www.youtube.com/watch?v=_oet4GOzcRQ)

1. You can use subscription key from Task 1 (or create new)

2. Use [attached application](https://github.com/vaclavek/CloudDevelopment/tree/master/Lab-2019-04-10/02_OCR), insert your own subscription key and run application

3. Processed image (use your own)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/ocr_1_image.jpg)

4. Look at the results:

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/ocr_1_result.png)

## Task 3 - Face detection

1. Find Cognitive Services in Azure Portal

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/cv_1_portal.png)

2. Add new Face service to Cognitive Services

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_1_portal.png)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_2_portal.png)

3. Find and copy your generated keys (like in tasks before)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_3_portal.png)

4. Use [attached application](https://github.com/vaclavek/CloudDevelopment/tree/master/Lab-2019-04-10/03_FaceDetection), insert your own subscription key and run application

5. Processed images (use your own)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_4_image.jpg)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_5_response.png)

![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_6_image.jpg)
![](https://raw.githubusercontent.com/vaclavek/CloudDevelopment/master/Images/face_7_response.png)

## Aditional resources
1. [Face detection](https://docs.microsoft.com/en-US/azure/cognitive-services/face/face-api-how-to-topics/howtodetectfacesinimage)
2. [Face identification](https://docs.microsoft.com/en-us/azure/cognitive-services/face/face-api-how-to-topics/howtoidentifyfacesinimage)
3. [Sample applications](https://azure.microsoft.com/en-us/resources/samples/?service=cognitive-services&term=Face&sort=0)
4. [More samples](https://github.com/Microsoft/Cognitive-Samples-IntelligentKiosk)
