# StorageERP(v1.0.0) : 

# 개요
- 범용적으로 사용하는 물품 보관 시스템

# 개발 기간
- 2020년 12월 14일 ~ 2020년 12월 21일 (2차 Mini Project)

# 구성원
- 양석원, 양창혁, 이주형, 임동희

# 기능 목록

## 관리자용 프로그램

### 1. 관리자 메인 화면

<div>
<img src="./TheProject/TheProject/Resources/동작화면/관리자_초기.png" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/관리자_출력.png" width="45%">
</div>

- 연간/월간 수입을 월별/일별로 구분하여 시각화한다.
- 보관함의 종류별로 구분하여 시각화 가능하다.
- Storage Activate/Deactivate를 통해 보관함의 활성화 여부를 실시간 업데이트 가능하다.

### 2. BingMap 화면

<div>
<img src="./TheProject/TheProject/Resources/동작화면/관리자_초기.png" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/관리자_출력.png" width="45%">
</div>

- 서울내에 보관함의 위치를 MapPushPin을 사용하여 BingMap에 나타낸다.
- MapPushPin에 마우스를 가져다대면 ToolTip으로 간단한 정보가 나타난다.
- MapPushPin을 클릭하면 상세 정보가 나타난다.

### 3. GanttChart 화면

<div>
<img src="./TheProject/TheProject/Resources/동작화면/관리자_초기.png" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/관리자_출력.png" width="45%">
</div>

- 보관소 위치별 보관함 사용 현황을 알 수 있다.
- 일반 / 신선 함별로 또는 기간별로 필터가 가능하다.


# 관리 항목

### 1. 보관함 정보

- 현재 보관함 상태에 따라 활성화/비활성화를 선택할 수 있다.
### 2. 관리자용 정보

- 월간/연간 매출액 추이를 그래프로 확인할 수 있다.
- 보관함 종류에 따라 데이터를 구분해 시각화할 수 있다.



# 사용 기술

## 언어

- C# 8.0

## 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.4
- Winform

## 데이터베이스

* MSSQL Server 2019

## 기타 개발환경

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# 데이터베이스 스키마

<img src="./TheProject/TheProject/Resources/동작화면/DatabaseSchema.png">

- StorageSelection table의 ExitDateExpected항목과 Reciept table의 TotalCost 항목은 역정규화한 결과이다.

- 이외의 모든 항목이 제 3 정규화까지 완료됐다


# UML

## 클래스 다이어그램
<img src="./TheProject/TheProject/Resources/동작화면/ClassDiagram.png">


## User Case Diagram

<img src="./TheProject/TheProject/Resources/동작화면/UserCaseDiagram.png">

## 순서도

<div>
<img src="./StorageERP/StorageERP/Picture/flowChart.JPG" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/순서도1.png" width="30%">
<img src="./TheProject/TheProject/Resources/동작화면/순서도2.png" width="60%">
</div>

# Point of Interest

# Data Analysis시 기본값이 제대로 출력되지 않는 문제 [#11](https://github.com/snrbs17/603_TeamProject/issues/11)

## 증상
- TimeScope를 Yearly로 설정한 후 바로 Search를 누를 경우 잘못된 값이 출력됨

## 원인
- Form 전체에 default값이 Monthly TimeScope 11월을 기준으로 설정되어 있음

## 결과
- TimeScope 설정이 바꿨을 때 default값이 새로 지정되도록 함수의 위치를 변경

# DGV_Search 에 페이지를 나누는 동작이 반영되지 않은 문제 [#9](https://github.com/snrbs17/603_TeamProject/issues/9)

## 증상
- DGV에 항목을 5개씩 표시해주고 이전/다음페이지 누르면 넘어가게 구현중이나 항목 나눠지는게 안먹히고 한번에 다 나옴

## 원인
- 가져온 코드에서 상황에 맞춰 바꾼 부분이 원인으로 예상됨 (원인 찾는중)

## 결과
- 작업중





