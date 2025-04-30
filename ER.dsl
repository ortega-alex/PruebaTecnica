Project "sistema-servicios" {
  database_type: "SQLServer"
  Note: 'sistema-servicios'
}

table Customer {
  id int [pk, increment, not null]
  name varchar(100) [not null]
  code varchar(45)
  address varchar(250)
  email varchar(25)
  phone_number varchar(25)
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

Note ServiceSetting {
 'esta tabla serviria para configurar canales, velocidades para tipos de servicios'
}
table ServiceSetting {
  id int [pk, increment, not null]
  name varchar(45) [not null, note: '''aqui iria [velocidades para internet]
                                       15Mbps, 25Mbps, 50Mbps o cantidad 
                                       de canales para cable'''] 
  description varchar(250) 
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table ServiceType {
  id int [pk, increment, not null]
  name varchar(45) [not null]
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table ServiceLocation {
  id int [pk, increment, not null]
  city varchar(45)
  zone varchar(20)  
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

Note Service {
  '''
    con la combinacion de las tres tablas de ubicacion, typo y configuracion
    se puede establecer un consto por servicio'''
}
table Service {
  id int [pk, increment, not null]
  description varchar(250) [not null]
  monthly_cost decimal(10, 2) [not null]
  service_location_id int [not null, ref: > ServiceLocation.id]
  service_type_id int [not null, ref: > ServiceType.id]
  service_setting_id int [not null, ref: > ServiceSetting.id]
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table DiscountSetting {
  id int [pk, increment, not null]
  name varchar(100) [not null]
  description varchar(250)
  discount_percentage decimal(5, 2) [not null]
  service_upgrade varchar(100) [note: 'Ej: "+5Mbps"'] 
  condition_type varchar(20) [not null, note: '''firma, pago, 
                                              fidelización, promocional''']
  condition_value varchar(100) [note: 'por ejemplo: 12 meses, antes del 10, etc.']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table Contract {
  id int [pk, increment, not null]
  id_customer int [not null, ref: > Customer.id]
  start_date datetime [not null]
  end_date datetime
  pay_period varchar(20) [note: 'mensual, bimestral, anual']
  discount_percentage decimal(5, 2) [note: 'descuento general si aplica']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table ContractDetail {
  id int [pk, increment, not null]
  contract_id int [not null, ref: > Contract.id]
  service_id int [not null, ref: > Service.id]
  price decimal(10,2) [not null, note: 'Precio sin descuento']
  discount_percentage decimal(5, 2) [note: 'si aplica algun descuento']
  service_start_date datetime [not null]
  billing_frequency varchar(20) [note: 'mensual, trimestral, anual']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

Note ContractDiscount{
  ''' 
  (Registro de descuentos aplicados al contrato)
    Esta tabla une los descuentos que realmente 
    se aplicaron en un contrato específico

  - Cuando creas un contrato, consultas DiscountSetting 
    para ver si el cliente califica a un descuento de firma (signing).

  -Cuando genera la factura, puedes hacer una revisión para aplicar
   descuentos de tipo payment (por pronto pago).

  -Cada año, puedes programar una revisión de antigüedad para 
   aplicar loyalty (lealtad) automáticamente.

  - Y puedes tener descuentos promocionales (promotional) que se 
    aplican de manera especial.

  '''
}
table ContractDiscount {
  id int [pk, increment, not null]
  contract_id int [not null, ref: > Contract.id]
  discount_setting_id int [not null, ref: > DiscountSetting.id]
  applied_at datetime [default: `current_timestamp`]
  applied_amount decimal(10,2) [note: 'cuánto se descontó realmente']
  note varchar(250)
  is_active bit [default: 1]
}

table Corretative {
  id int [pk, increment, not null]
  serie varchar(3) [note: 'ejp: 001, 002, etc']
  number int [not null]
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table Bill {
  id int [pk, increment, not null]
  id_contract int [not null, ref: > Contract.id]
  number varchar(20) [not null, note: 'número de factura, ej: 001-000001']
  invoice_date datetime [not null]
  due_date datetime
  total_amount decimal(10, 2) [not null]
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table BillDetail {
  id int [pk, increment, not null]
  bill_id int [not null, ref: > Bill.id]
  contract_detail_id int [not null, ref: > ContractDetail.id]
  service_id int [not null, ref: > Service.id]
  service_amount decimal(10, 2) [not null]
  billing_period varchar(20) [note: 'ej: Abril 2025']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table Payment {
  id int [pk, increment, not null]
  bill_id int [not null, ref: > Bill.id]
  payment_date datetime [default: `current_timestamp`]
  amount decimal(10, 2)
  method varchar(20) [note: 'efectivo, tarjeta, transferencia']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table SuspendedService {
  id int [pk, increment, not null]
  contract_id int [not null, ref: > Contract.id]
  service_id int [not null, ref: > Service.id]
  suspension_date datetime [default: `current_timestamp`, not null]
  reason varchar(250) [default: 'Falta de pago']
  reactivation_date datetime
  is_active bit [default: 1]
}

// sub modulo de RRHH
table EmployeeType {
  id int [pk, increment, not null]
  name varchar(100) [not null, note: 'secretaria, instalador, técnico, guardia']
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table Employee {
  id int [pk, increment, not null]
  name varchar(100) [not null]
  employee_type_id int [not null, ref:> EmployeeType.id]
  base_salary decimal(10,2) [not null]
  hire_date datetime [not null]
  is_active bit [default: 1]
  created_at datetime [default: `current_timestamp`]
  edited_at datetime
}

table Payroll {
  id int [pk, increment, not null]
  employee_id int [not null, ref: > Employee.id]
  period_start datetime [not null]
  period_end datetime [not null]
  gross_salary decimal(10,2) [not null]
  igss_contribution decimal(10,2) [note: 'IGSS: 4.83% del salario, por ejemplo.']
  isr_retention decimal(10,2)
  net_salary decimal(10,2) [not null]
  payment_date datetime
  is_paid bit [default: 0]
}














