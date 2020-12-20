# StorageERP(v1.0.0) : 

# 개요
- 범용적으로 사용하는 물품 보관 시스템

# 개발 기간
- 2020년 12월 14일 ~ 2020년 12월 21일 (2차 Mini Project)

# 구성원
- 양석원, 양창혁, 이주형, 임동희

# 기능 목록

## 물품 보관용 프로그램

### 1. 회원 가입 및 로그인

<div>
<img src="./TheProject/TheProject/Resources/동작화면/회원가입.png" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/로그인.png" width="45%">
</div>

- 회원 가입을 하면 ID 중복판단 후 Password가 맞으면 다음 창으로 넘어간다.
- ID와 Password 확인 후 로그인.

### 2. 선택 (입고, 출고, 검색)

<img src="./TheProject/TheProject/Resources/동작화면/선택화면.png" width="45%">

- 원하는 항목을 선택한다.

### 2-1. 입고 선택

<img src="./TheProject/TheProject/Resources/동작화면/선택_입고.png" width="45%">

- 입고 선택시 일반/신선에 따라 다른 보관함을 지정하여 사용한다.
- 보관함을 선택하고 시간을 지정한 뒤 결제를 한다.

### 2-2. 출고 선택

<img src="./TheProject/TheProject/Resources/동작화면/선택_출고.png" width="45%">

- 원하는 보관함을 선택하고 출고한다.
- 출고 시 시간이 지났다면 추과금이 부여된다.

### 2-3. 검색 선택

<img src="./TheProject/TheProject/Resources/동작화면/선택_검색.png" width="45%">

- 현재 사용중인 보관함을 확인한다.
- 과거 데이터를 확인한다.



## 관리자용 프로그램

### 1. 관리자 화면

<div>
<img src="./TheProject/TheProject/Resources/동작화면/관리자_초기.png" width="45%">
<img src="./TheProject/TheProject/Resources/동작화면/관리자_출력.png" width="45%">
</div>

- 연간/월간 수입을 월별/일별로 구분하여 시각화한다.
- 보관함의 종류별로 구분하여 시각화 가능하다.
- Storage Activate/Deactivate를 통해 보관함의 활성화 여부를 실시간 업데이트 가능하다.


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


# DGV_Payment 에 선택하는 ComboBox가 실시간으로 반영되지 않은 문제 [#8](https://github.com/snrbs17/603_TeamProject/issues/8)

## 증상
- DGV에 ComboBox를 넣어 선택 시 실시간으로 반영되지않고 옆의 Cell이나 다른 버튼의 동작 이후에 결과가 반영된다.

## 원인
- 클릭 문제로 예상된다. (원인 찾는중)

## 결과
- 작업중


# DGV_Storage 에 나타나는 DB 데이터가 코드 변환 에러가 떠서 반영되지 않은 문제 [#7](https://github.com/snrbs17/603_TeamProject/issues/7)

## 증상
- DGV에 DB를 가져올때 에러 발생

## 원인
- DB와 코드상에 CanUse는 bool로 StorageTypeId는 int로 설정되어있어 string으로 변경 불가하다고 에러창에 표기되었다.
- DateTime은 시간이 같이 나와야하나 날짜만 나오고 있다.

## 결과
- 작업중

# Data Grid View에 값이 출력되지 않는 오류

## 증상
- LINQ문으로 데이터를 가지고는 와지나 DGV에 입력되지 않았다.
## 원인
- Data Grid View에 바인딩되지 않았다.
- MSSQL 테이블에서 직접 가져오지 않고 join문과 groupby문을 거쳐왔기 때문에 추가적인 작업이 필요했다.
## 결과
- LINQ의 결과로 가져온 데이터를 나타낼 수 있는 class들을 선언해 Entities 폴더를 구성했다.
- 각 class들을 DGV에 인식시킨 후 LINQ로 각 class의 인스턴스 list를 가져와 DGV에 입력했다.

<img src="./TheProject/TheProject/Resources/동작화면/DGV해결.png">



