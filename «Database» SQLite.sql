/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 12.1 		*/
/*  Created On : 29-Sep-2019 20:28:25 				*/
/*  DBMS       : SQLite 								*/
/* ---------------------------------------------------- */

/* Drop Tables */

DROP TABLE IF EXISTS 'Customer_Payment_Details'
;

DROP TABLE IF EXISTS 'Customers'
;

DROP TABLE IF EXISTS 'Invoices'
;

DROP TABLE IF EXISTS 'Order_Items'
;

DROP TABLE IF EXISTS 'Orders'
;

DROP TABLE IF EXISTS 'Payments'
;

DROP TABLE IF EXISTS 'Products'
;

DROP TABLE IF EXISTS 'Ref_Invoice_Status_Codes'
;

DROP TABLE IF EXISTS 'Ref_Order_Item_Status_Codes'
;

DROP TABLE IF EXISTS 'Ref_Order_Status'
;

DROP TABLE IF EXISTS 'Ref_Payment_Types'
;

DROP TABLE IF EXISTS 'Ref_Product_Types'
;

DROP TABLE IF EXISTS 'Shipment_Items'
;

DROP TABLE IF EXISTS 'Shipments'
;

/* Create Tables with Primary and Foreign Keys, Check and Unique Constraints */

CREATE TABLE 'Customer_Payment_Details'
(
	'customer_payment_id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	'customer_id' INTEGER NOT NULL,
	'customer_payment_method_code' INTEGER,
	'credit_card_detail' TEXT,
	'payment_details' TEXT,
	'payment_method_code' INTEGER,
	CONSTRAINT 'FK_Customer_Payment_Details_Customers' FOREIGN KEY ('customer_id') REFERENCES 'Customers' ('customer_id') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Customer_Payment_Details_Ref_Payment_Types' FOREIGN KEY ('payment_method_code') REFERENCES 'Ref_Payment_Types' ('payment_method_code') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Customers'
(
	'customer_id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	'organization_or_person' INTEGER,
	'organization_name' TEXT,
	'gender' INTEGER,
	'first_name' TEXT,
	'middle_name' TEXT,
	'email_address' TEXT,
	'login_name' TEXT,
	'login_password' TEXT,
	'phone_number' INTEGER,
	'address_line1' TEXT,
	'address_line2' TEXT,
	'address_line3' TEXT,
	'address_line4' TEXT,
	'town_city' TEXT,
	'county_province' TEXT,
	'country' INTEGER
)
;

CREATE TABLE 'Invoices'
(
	'invoice_number' INTEGER NOT NULL PRIMARY KEY,
	'order_id' INTEGER NOT NULL,
	'invoice_status_code' INTEGER,
	'invoice_date' TEXT,
	'invoice_details' TEXT,
	CONSTRAINT 'FK_Invoices_Ref_Invoice_Status_Codes' FOREIGN KEY ('invoice_status_code') REFERENCES 'Ref_Invoice_Status_Codes' ('invoice_status_code') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Order_Items'
(
	'order_item_id' INTEGER NOT NULL PRIMARY KEY,
	'product_id' INTEGER NOT NULL,
	'order_id' INTEGER NOT NULL,
	'order_item_status_code' INTEGER NOT NULL,
	'order_item_quantity' INTEGER NOT NULL DEFAULT 0,
	'order_item_price' NUMERIC NOT NULL,
	'RMA_number' INTEGER,
	'RMA_issued_by' TEXT,
	'RMA_issued_date' TEXT,
	'other_order_item_details' TEXT,
	CONSTRAINT 'FK_Order_Items_Orders' FOREIGN KEY ('order_id') REFERENCES 'Orders' ('order_id') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Order_Items_Ref_Order_Item_Status_Codes' FOREIGN KEY ('order_item_status_code') REFERENCES 'Ref_Order_Item_Status_Codes' ('order_item_status_code') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Orders'
(
	'order_id' INTEGER NOT NULL PRIMARY KEY,
	'customer_id' INTEGER NOT NULL,
	'order_status_code' INTEGER NOT NULL,
	'date_order_placed' TEXT,
	'order_details' TEXT,
	CONSTRAINT 'FK_Orders_Customers' FOREIGN KEY ('customer_id') REFERENCES 'Customers' ('customer_id') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Orders_Ref_Order_Status' FOREIGN KEY ('order_status_code') REFERENCES 'Ref_Order_Status' ('order_status_code') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Payments'
(
	'payment_id' INTEGER NOT NULL PRIMARY KEY,
	'invoice_number' INTEGER NOT NULL,
	'payment_date' TEXT NOT NULL,
	'payment_amount' NUMERIC NOT NULL,
	CONSTRAINT 'FK_Payments_Invoices' FOREIGN KEY ('invoice_number') REFERENCES 'Invoices' ('invoice_number') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Products'
(
	'product_id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	'product_type_code' INTEGER NOT NULL,
	'return_merchant_auth_nr' INTEGER NOT NULL,
	'product_name' TEXT NOT NULL,
	'product_price' NUMERIC NOT NULL DEFAULT 0,
	'product_color' INTEGER,
	'product_size' INTEGER,
	'product_description' TEXT,
	'product_other_details' TEXT,
	CONSTRAINT 'FK_Products_Ref_Product_Types' FOREIGN KEY ('product_type_code') REFERENCES 'Ref_Product_Types' ('product_type_code') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Ref_Invoice_Status_Codes'
(
	'invoice_status_code' INTEGER NOT NULL PRIMARY KEY,
	'invoice_status_description' TEXT NOT NULL
)
;

CREATE TABLE 'Ref_Order_Item_Status_Codes'
(
	'order_item_status_code' INTEGER NOT NULL PRIMARY KEY,
	'order_item_status_description' TEXT
)
;

CREATE TABLE 'Ref_Order_Status'
(
	'order_status_code' INTEGER NOT NULL PRIMARY KEY,
	'order_status_description' TEXT
)
;

CREATE TABLE 'Ref_Payment_Types'
(
	'payment_method_code' INTEGER NOT NULL PRIMARY KEY,
	'payment_method_description' TEXT
)
;

CREATE TABLE 'Ref_Product_Types'
(
	'product_type_code' INTEGER NOT NULL PRIMARY KEY,
	'parent_product_type_code' INTEGER,
	'product_type_description' TEXT
)
;

CREATE TABLE 'Shipment_Items'
(
	'shipment_id' INTEGER NOT NULL,
	'order_item_id' INTEGER NOT NULL,
	CONSTRAINT 'FK_Shipment_Items_Order_Items' FOREIGN KEY ('order_item_id') REFERENCES 'Order_Items' ('order_item_id') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Shipment_Items_Shipments' FOREIGN KEY ('shipment_id') REFERENCES 'Shipments' ('shipment_id') ON DELETE No Action ON UPDATE No Action
)
;

CREATE TABLE 'Shipments'
(
	'shipment_id' INTEGER NOT NULL PRIMARY KEY,
	'order_id' INTEGER NOT NULL,
	'invoice_number' INTEGER NOT NULL,
	'shipment_tracking_number' INTEGER,
	'shipment_date' TEXT,
	'other_shipment_details' TEXT,
	CONSTRAINT 'FK_Shipments_Invoices' FOREIGN KEY ('invoice_number') REFERENCES 'Invoices' ('invoice_number') ON DELETE No Action ON UPDATE No Action,
	CONSTRAINT 'FK_Shipments_Orders' FOREIGN KEY ('order_id') REFERENCES 'Orders' ('order_id') ON DELETE No Action ON UPDATE No Action
)
;

/* Create Indexes and Triggers */

CREATE INDEX 'IXFK_Customer_Payment_Details_Customers'
 ON 'Customer_Payment_Details' ('customer_id' ASC)
;

CREATE INDEX 'IXFK_Customer_Payment_Details_Ref_Payment_Types'
 ON 'Customer_Payment_Details' ('payment_method_code' ASC)
;

CREATE INDEX 'IXFK_Invoices_Ref_Invoice_Status_Codes'
 ON 'Invoices' ('invoice_status_code' ASC)
;

CREATE INDEX 'IXFK_Order_Items_Orders'
 ON 'Order_Items' ('order_id' ASC)
;

CREATE INDEX 'IXFK_Order_Items_Ref_Order_Item_Status_Codes'
 ON 'Order_Items' ('order_item_status_code' ASC)
;

CREATE INDEX 'IXFK_Orders_Customers'
 ON 'Orders' ('customer_id' ASC)
;

CREATE INDEX 'IXFK_Orders_Ref_Order_Status'
 ON 'Orders' ('order_status_code' ASC)
;

CREATE INDEX 'IXFK_Payments_Invoices'
 ON 'Payments' ('invoice_number' ASC)
;

CREATE INDEX 'IXFK_Products_Ref_Product_Types'
 ON 'Products' ('product_type_code' ASC)
;

CREATE INDEX 'IXFK_Shipment_Items_Order_Items'
 ON 'Shipment_Items' ('order_item_id' ASC)
;

CREATE INDEX 'IXFK_Shipment_Items_Shipments'
 ON 'Shipment_Items' ('shipment_id' ASC)
;

CREATE INDEX 'IXFK_Shipments_Invoices'
 ON 'Shipments' ('invoice_number' ASC)
;

CREATE INDEX 'IXFK_Shipments_Orders'
 ON 'Shipments' ('order_id' ASC)
;
