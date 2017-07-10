#pragma once

#include <sstream>

namespace calculatorCLR {


	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	string opers = "+-/*";	//use for check when entering an equation
	string equationStr;		
	int eqSize;				//allocate memory for equation string size

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^  calcDisplay;
	protected: 

	protected: 
	private: System::Windows::Forms::Button^  btn1;
	private: System::Windows::Forms::Button^  btn2;
	private: System::Windows::Forms::Button^  btn3;
	private: System::Windows::Forms::Button^  btn4;
	private: System::Windows::Forms::Button^  btn5;
	private: System::Windows::Forms::Button^  btn6;
	private: System::Windows::Forms::Button^  btn7;
	private: System::Windows::Forms::Button^  btn8;
	private: System::Windows::Forms::Button^  btn9;
	private: System::Windows::Forms::Button^  btn0;
	private: System::Windows::Forms::Button^  btnDec;
	private: System::Windows::Forms::Button^  btnAdd;
	private: System::Windows::Forms::Button^  btnMin;
	private: System::Windows::Forms::Button^  btnMul;
	private: System::Windows::Forms::Button^  btnDiv;
	private: System::Windows::Forms::Button^  btnEq;
	private: System::Windows::Forms::Button^  btnClear;
	private: System::Windows::Forms::TextBox^  calcAnswer;
	private: System::Windows::Forms::Button^  btnLparen;
	private: System::Windows::Forms::Button^  btnRparen;



	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->calcDisplay = (gcnew System::Windows::Forms::TextBox());
			this->btn1 = (gcnew System::Windows::Forms::Button());
			this->btn2 = (gcnew System::Windows::Forms::Button());
			this->btn3 = (gcnew System::Windows::Forms::Button());
			this->btn4 = (gcnew System::Windows::Forms::Button());
			this->btn5 = (gcnew System::Windows::Forms::Button());
			this->btn6 = (gcnew System::Windows::Forms::Button());
			this->btn7 = (gcnew System::Windows::Forms::Button());
			this->btn8 = (gcnew System::Windows::Forms::Button());
			this->btn9 = (gcnew System::Windows::Forms::Button());
			this->btn0 = (gcnew System::Windows::Forms::Button());
			this->btnDec = (gcnew System::Windows::Forms::Button());
			this->btnAdd = (gcnew System::Windows::Forms::Button());
			this->btnMin = (gcnew System::Windows::Forms::Button());
			this->btnMul = (gcnew System::Windows::Forms::Button());
			this->btnDiv = (gcnew System::Windows::Forms::Button());
			this->btnEq = (gcnew System::Windows::Forms::Button());
			this->btnClear = (gcnew System::Windows::Forms::Button());
			this->calcAnswer = (gcnew System::Windows::Forms::TextBox());
			this->btnLparen = (gcnew System::Windows::Forms::Button());
			this->btnRparen = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// calcDisplay
			// 
			this->calcDisplay->Location = System::Drawing::Point(14, 12);
			this->calcDisplay->Multiline = true;
			this->calcDisplay->Name = L"calcDisplay";
			this->calcDisplay->Size = System::Drawing::Size(264, 54);
			this->calcDisplay->TabIndex = 0;
			this->calcDisplay->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox1_TextChanged);
			// 
			// btn1
			// 
			this->btn1->Location = System::Drawing::Point(14, 123);
			this->btn1->Name = L"btn1";
			this->btn1->Size = System::Drawing::Size(39, 38);
			this->btn1->TabIndex = 1;
			this->btn1->Text = L"1";
			this->btn1->UseVisualStyleBackColor = true;
			this->btn1->Click += gcnew System::EventHandler(this, &MyForm::btn1_Click);
			// 
			// btn2
			// 
			this->btn2->Location = System::Drawing::Point(59, 123);
			this->btn2->Name = L"btn2";
			this->btn2->Size = System::Drawing::Size(39, 38);
			this->btn2->TabIndex = 2;
			this->btn2->Text = L"2";
			this->btn2->UseVisualStyleBackColor = true;
			this->btn2->Click += gcnew System::EventHandler(this, &MyForm::btn2_Click);
			// 
			// btn3
			// 
			this->btn3->Location = System::Drawing::Point(104, 123);
			this->btn3->Name = L"btn3";
			this->btn3->Size = System::Drawing::Size(39, 38);
			this->btn3->TabIndex = 3;
			this->btn3->Text = L"3";
			this->btn3->UseVisualStyleBackColor = true;
			this->btn3->Click += gcnew System::EventHandler(this, &MyForm::btn3_Click);
			// 
			// btn4
			// 
			this->btn4->Location = System::Drawing::Point(14, 167);
			this->btn4->Name = L"btn4";
			this->btn4->Size = System::Drawing::Size(39, 38);
			this->btn4->TabIndex = 4;
			this->btn4->Text = L"4";
			this->btn4->UseVisualStyleBackColor = true;
			this->btn4->Click += gcnew System::EventHandler(this, &MyForm::btn4_Click);
			// 
			// btn5
			// 
			this->btn5->Location = System::Drawing::Point(59, 167);
			this->btn5->Name = L"btn5";
			this->btn5->Size = System::Drawing::Size(39, 38);
			this->btn5->TabIndex = 5;
			this->btn5->Text = L"5";
			this->btn5->UseVisualStyleBackColor = true;
			this->btn5->Click += gcnew System::EventHandler(this, &MyForm::btn5_Click);
			// 
			// btn6
			// 
			this->btn6->Location = System::Drawing::Point(104, 167);
			this->btn6->Name = L"btn6";
			this->btn6->Size = System::Drawing::Size(39, 38);
			this->btn6->TabIndex = 6;
			this->btn6->Text = L"6";
			this->btn6->UseVisualStyleBackColor = true;
			this->btn6->Click += gcnew System::EventHandler(this, &MyForm::btn6_Click);
			// 
			// btn7
			// 
			this->btn7->Location = System::Drawing::Point(14, 211);
			this->btn7->Name = L"btn7";
			this->btn7->Size = System::Drawing::Size(39, 38);
			this->btn7->TabIndex = 7;
			this->btn7->Text = L"7";
			this->btn7->UseVisualStyleBackColor = true;
			this->btn7->Click += gcnew System::EventHandler(this, &MyForm::btn7_Click);
			// 
			// btn8
			// 
			this->btn8->Location = System::Drawing::Point(59, 211);
			this->btn8->Name = L"btn8";
			this->btn8->Size = System::Drawing::Size(39, 38);
			this->btn8->TabIndex = 8;
			this->btn8->Text = L"8";
			this->btn8->UseVisualStyleBackColor = true;
			this->btn8->Click += gcnew System::EventHandler(this, &MyForm::btn8_Click);
			// 
			// btn9
			// 
			this->btn9->Location = System::Drawing::Point(104, 211);
			this->btn9->Name = L"btn9";
			this->btn9->Size = System::Drawing::Size(39, 38);
			this->btn9->TabIndex = 9;
			this->btn9->Text = L"9";
			this->btn9->UseVisualStyleBackColor = true;
			this->btn9->Click += gcnew System::EventHandler(this, &MyForm::btn9_Click);
			// 
			// btn0
			// 
			this->btn0->Location = System::Drawing::Point(14, 255);
			this->btn0->Name = L"btn0";
			this->btn0->Size = System::Drawing::Size(84, 38);
			this->btn0->TabIndex = 10;
			this->btn0->Text = L"0";
			this->btn0->UseVisualStyleBackColor = true;
			this->btn0->Click += gcnew System::EventHandler(this, &MyForm::btn0_Click);
			// 
			// btnDec
			// 
			this->btnDec->Location = System::Drawing::Point(104, 255);
			this->btnDec->Name = L"btnDec";
			this->btnDec->Size = System::Drawing::Size(39, 38);
			this->btnDec->TabIndex = 11;
			this->btnDec->Text = L".";
			this->btnDec->UseVisualStyleBackColor = true;
			this->btnDec->Click += gcnew System::EventHandler(this, &MyForm::btnDec_Click);
			// 
			// btnAdd
			// 
			this->btnAdd->Location = System::Drawing::Point(149, 123);
			this->btnAdd->Name = L"btnAdd";
			this->btnAdd->Size = System::Drawing::Size(39, 38);
			this->btnAdd->TabIndex = 12;
			this->btnAdd->Text = L"+";
			this->btnAdd->UseVisualStyleBackColor = true;
			this->btnAdd->Click += gcnew System::EventHandler(this, &MyForm::btnAdd_Click);
			// 
			// btnMin
			// 
			this->btnMin->Location = System::Drawing::Point(149, 167);
			this->btnMin->Name = L"btnMin";
			this->btnMin->Size = System::Drawing::Size(39, 38);
			this->btnMin->TabIndex = 13;
			this->btnMin->Text = L"-";
			this->btnMin->UseVisualStyleBackColor = true;
			this->btnMin->Click += gcnew System::EventHandler(this, &MyForm::btnMin_Click);
			// 
			// btnMul
			// 
			this->btnMul->Location = System::Drawing::Point(149, 211);
			this->btnMul->Name = L"btnMul";
			this->btnMul->Size = System::Drawing::Size(39, 38);
			this->btnMul->TabIndex = 14;
			this->btnMul->Text = L"*";
			this->btnMul->UseVisualStyleBackColor = true;
			this->btnMul->Click += gcnew System::EventHandler(this, &MyForm::btnMul_Click);
			// 
			// btnDiv
			// 
			this->btnDiv->Location = System::Drawing::Point(149, 255);
			this->btnDiv->Name = L"btnDiv";
			this->btnDiv->Size = System::Drawing::Size(39, 38);
			this->btnDiv->TabIndex = 15;
			this->btnDiv->Text = L"/";
			this->btnDiv->UseVisualStyleBackColor = true;
			this->btnDiv->Click += gcnew System::EventHandler(this, &MyForm::btnDiv_Click);
			// 
			// btnEq
			// 
			this->btnEq->Location = System::Drawing::Point(239, 211);
			this->btnEq->Name = L"btnEq";
			this->btnEq->Size = System::Drawing::Size(39, 82);
			this->btnEq->TabIndex = 16;
			this->btnEq->Text = L"=";
			this->btnEq->UseVisualStyleBackColor = true;
			this->btnEq->Click += gcnew System::EventHandler(this, &MyForm::btnEq_Click);
			// 
			// btnClear
			// 
			this->btnClear->Location = System::Drawing::Point(194, 211);
			this->btnClear->Name = L"btnClear";
			this->btnClear->Size = System::Drawing::Size(39, 82);
			this->btnClear->TabIndex = 17;
			this->btnClear->Text = L"Clear";
			this->btnClear->UseVisualStyleBackColor = true;
			this->btnClear->Click += gcnew System::EventHandler(this, &MyForm::btnClear_Click);
			// 
			// calcAnswer
			// 
			this->calcAnswer->Location = System::Drawing::Point(14, 72);
			this->calcAnswer->Multiline = true;
			this->calcAnswer->Name = L"calcAnswer";
			this->calcAnswer->Size = System::Drawing::Size(264, 45);
			this->calcAnswer->TabIndex = 18;
			// 
			// btnLparen
			// 
			this->btnLparen->Location = System::Drawing::Point(194, 167);
			this->btnLparen->Name = L"btnLparen";
			this->btnLparen->Size = System::Drawing::Size(39, 38);
			this->btnLparen->TabIndex = 19;
			this->btnLparen->Text = L"(";
			this->btnLparen->UseVisualStyleBackColor = true;
			this->btnLparen->Click += gcnew System::EventHandler(this, &MyForm::btnLparen_Click);
			// 
			// btnRparen
			// 
			this->btnRparen->Location = System::Drawing::Point(239, 167);
			this->btnRparen->Name = L"btnRparen";
			this->btnRparen->Size = System::Drawing::Size(39, 38);
			this->btnRparen->TabIndex = 20;
			this->btnRparen->Text = L")";
			this->btnRparen->UseVisualStyleBackColor = true;
			this->btnRparen->Click += gcnew System::EventHandler(this, &MyForm::btnRparen_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(292, 303);
			this->Controls->Add(this->btnRparen);
			this->Controls->Add(this->btnLparen);
			this->Controls->Add(this->calcAnswer);
			this->Controls->Add(this->btnClear);
			this->Controls->Add(this->btnEq);
			this->Controls->Add(this->btnDiv);
			this->Controls->Add(this->btnMul);
			this->Controls->Add(this->btnMin);
			this->Controls->Add(this->btnAdd);
			this->Controls->Add(this->btnDec);
			this->Controls->Add(this->btn0);
			this->Controls->Add(this->btn9);
			this->Controls->Add(this->btn8);
			this->Controls->Add(this->btn7);
			this->Controls->Add(this->btn6);
			this->Controls->Add(this->btn5);
			this->Controls->Add(this->btn4);
			this->Controls->Add(this->btn3);
			this->Controls->Add(this->btn2);
			this->Controls->Add(this->btn1);
			this->Controls->Add(this->calcDisplay);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
			 }
	private: System::Void textBox1_TextChanged(System::Object^  sender, System::EventArgs^  e) {

			 }
private: System::Void btn1_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "1";
		 }
private: System::Void btn2_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "2";
		 }
private: System::Void btn3_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "3";
		 }
private: System::Void btn4_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "4";
		 }
private: System::Void btn5_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "5";
		 }
private: System::Void btn6_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "6";
		 }
private: System::Void btn7_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "7";
		 }
private: System::Void btn8_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "8";
		 }
private: System::Void btn9_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "9";
		 }
private: System::Void btn0_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "0";
		 }
private: System::Void btnClear_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text = "";
		 }
private: System::Void btnAdd_Click(System::Object^  sender, System::EventArgs^  e) {
			 equationStr = calcDisplay->Text;
			 eqSize = equationStr.length();
			 stringstream op;
			 char lastchar = equationStr[eqSize-1];
			 if(opers.find(lastchar)){
				 calcDisplay->Text += "+";
			 }

		 }
private: System::Void btnMin_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "-";
		 }
private: System::Void btnMul_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "*";
		 }
private: System::Void btnDiv_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "/";
		 }
private: System::Void btnDec_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += ".";
		 }
private: System::Void btnLparen_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += "(";
		 }
private: System::Void btnRparen_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcDisplay->Text += ")";
		 }
private: System::Void btnEq_Click(System::Object^  sender, System::EventArgs^  e) {
			 calcAnswer->Text = "";
			 
		 }
};
}
