#include "MyForm.h"

#include <iostream>

using namespace std;
using namespace System;

using namespace System;
using namespace System::Windows::Forms;

[STAThread]
void main(array<String^>^ args) {
    Application::EnableVisualStyles();
    Application::SetCompatibleTextRenderingDefault(false);
    Application::Run(gcnew calculatorCLR::MyForm);

}
